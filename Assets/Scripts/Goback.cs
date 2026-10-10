using UnityEngine;

public class Goback : MonoBehaviour
{
    [SerializeField] GameObject startingpoint; 
    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = startingpoint.transform.position;
    }
}
