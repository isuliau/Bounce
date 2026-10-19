using UnityEngine;

public class Setterback : MonoBehaviour
{
    [SerializeField] MovingSpike f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        f.f = 0;
    }
}
