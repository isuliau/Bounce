using System.Numerics;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private SpriteRenderer renderers;
    public Spawn spawn;

    private void Start()
    {
        renderers = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        renderers.color = Color.green;
        spawn.transform.position = this.transform.position;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        renderers.color = new Color(0.1534591f, 0.5754717f, 0f, 1f);
    }
}
