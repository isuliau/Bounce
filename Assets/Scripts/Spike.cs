using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject spawn;
    private Collider2D playercollider;
    void Start()
    {
        playercollider = player.GetComponent<Collider2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == playercollider)
        player.transform.position = spawn.transform.position;
    }
}
