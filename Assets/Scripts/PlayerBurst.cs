using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBurst : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject soul;
    [SerializeField] private GameObject BurstDarken;
    [SerializeField] private Player player;
    [SerializeField] private Animator m_Animator;
    [SerializeField] private float rayDistance = 2f;
    [SerializeField] private LayerMask obstacleLayer;
    [SerializeField] private float push;

    private float directiony = 0;
    private float directionx = 0;
    public bool pushed = false;
    private bool souling = true;

    public void Burst()
    {
        if (souling && !player.jumped)
        {
            Vector2[] directions = new Vector2[]
            {
                transform.right,                         
                -transform.right,                        
                transform.up,                            
                -transform.up,                            
                new Vector2(1, 1).normalized,               
                new Vector2(-1, 1).normalized,              
                new Vector2(1, -1).normalized,             
                new Vector2(-1, -1).normalized            
            };
            RaycastHit2D hitR  = CastRay(directions[0]);
            RaycastHit2D hitL  = CastRay(directions[1]);
            RaycastHit2D hitU  = CastRay(directions[2]);
            RaycastHit2D hitD  = CastRay(directions[3]);
            RaycastHit2D hitRU = CastRay(directions[4]);
            RaycastHit2D hitLU = CastRay(directions[5]);
            RaycastHit2D hitRD = CastRay(directions[6]);
            RaycastHit2D hitLD = CastRay(directions[7]);
            if (hitR.collider != null)  { directionx -= push; pushed = true; }
            if (hitL.collider != null)  { directionx += push; pushed = true; }
            if (hitU.collider != null)  { directiony -= push; pushed = true; }
            if (hitD.collider != null)  { directiony += push; pushed = true; }
            if (hitRU.collider != null) { directionx -= push; directiony -= push; pushed = true; }
            if (hitLU.collider != null) { directionx += push; directiony -= push; pushed = true; }
            if (hitRD.collider != null) { directionx -= push; directiony += push; pushed = true; } 
            if (hitLD.collider != null) { directionx += push; directiony += push; pushed = true; }

            rb.AddForce(new Vector2(directionx, directiony), ForceMode2D.Impulse);
            directiony = 0; 
            directionx = 0;

            StartCoroutine(SoulMode());
        }
    }


    private RaycastHit2D CastRay(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, rayDistance, obstacleLayer);
        return hit;
    }

    public IEnumerator SoulMode()
    {
        m_Animator.SetBool("burst 0", true);
        soul.SetActive(true);
        souling = false;

        if ((Mathf.Abs(rb.linearVelocity.x) > 50 || Mathf.Abs(rb.linearVelocity.y) > 50) && pushed && !player.jumped)
        {
            Time.timeScale = 0.5f;
            BurstDarken.SetActive(true);
        }

        yield return new WaitForSeconds(0.1f);
        soul.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        pushed = false;
        m_Animator.SetBool("burst 0", false);
        yield return new WaitForSeconds(0.2f);
        BurstDarken.SetActive(false);
        Time.timeScale = 1f;
        souling = true;
        
    }

}
