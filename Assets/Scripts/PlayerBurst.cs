using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
public class PlayerBurst : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject soul;
    private Vector2 rayDirection;
  [SerializeField] private float rayDistance = 2f;
    [SerializeField] private LayerMask obstacleLayer;
    [SerializeField] private float push;
    private float directiony = 0;
    private float directionx = 0;
public void Burst()
    {
        if(souling){
        StartCoroutine(SoulMode());
        rayDirection = transform.right;
        RaycastHit2D hitr = Physics2D.Raycast(transform.position, rayDirection, rayDistance, obstacleLayer);
        rayDirection = -transform.right;
        RaycastHit2D hitl = Physics2D.Raycast(transform.position, rayDirection, rayDistance, obstacleLayer);
        rayDirection = transform.up;
        RaycastHit2D hitu = Physics2D.Raycast(transform.position, rayDirection, rayDistance, obstacleLayer);
        rayDirection = -transform.up;
        RaycastHit2D hitd = Physics2D.Raycast(transform.position, rayDirection, rayDistance, obstacleLayer);
        rayDirection = new Vector2 (1, 1);
        RaycastHit2D hitru = Physics2D.Raycast(transform.position, rayDirection, rayDistance, obstacleLayer);
        rayDirection = new Vector2 (-1, 1);
        RaycastHit2D hitlu = Physics2D.Raycast(transform.position, rayDirection, rayDistance, obstacleLayer);
        rayDirection = new Vector2 (1, -1);
        RaycastHit2D hitrd = Physics2D.Raycast(transform.position, rayDirection, rayDistance, obstacleLayer);
        rayDirection = new Vector2 (-1, -1);
        RaycastHit2D hitld = Physics2D.Raycast(transform.position, rayDirection, rayDistance, obstacleLayer);
    
        if (hitr.collider != null)
        {
         directionx -= push;   
        }
        if (hitl.collider != null)
        {
         directionx += push;   
        }
        if (hitu.collider != null)
        {
         directiony -= push;   
        }
        if (hitd.collider != null)
        {
         directiony += push;   
        }
        if (hitru.collider != null)
        {
         directionx -= push;   
         directiony -= push;  
        }
        if (hitlu.collider != null)
        {
         directionx += push;  
         directiony -= push;   
        }
        if (hitrd.collider != null)
        {
        directionx -= push; 
         directiony -= push;   
        }
        if (hitld.collider != null)
        {
        directionx += push; 
         directiony += push;   
        }
        rb.AddForce(new Vector2(directionx, directiony), ForceMode2D.Impulse);
    directiony = 0; directionx = 0;
    }}
private bool souling = true; 
   public IEnumerator SoulMode()
{
    soul.SetActive(true);
    souling = false;
    if(Mathf.Abs(rb.linearVelocity.x) > 50 || Mathf.Abs(rb.linearVelocity.y) > 50)
    Time.timeScale = 0.5f;
    yield return new WaitForSeconds(0.1f);
    soul.SetActive(false);
    yield return new WaitForSeconds(0.4f);
    Time.timeScale = 1f;
    souling = true;
}
}