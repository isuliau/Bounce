using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbPlayer;
    void OnTriggerEnter2D(Collider2D collision)
    {
        rbPlayer.linearVelocity = new Vector2 (0, 0);
    }
}
