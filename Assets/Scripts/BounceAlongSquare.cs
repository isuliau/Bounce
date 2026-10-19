using System.Drawing;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class BounceAlongSquare : MonoBehaviour
{

    [SerializeField] private Vector2 pointB;
    [SerializeField]  private float distance; [SerializeField]  private float speed;
    private void Update()
    {
        distance = distance + Time.deltaTime * speed;
        transform.position = new Vector2(Mathf.PingPong(distance , pointB.x), Mathf.PingPong(distance , pointB.y));
    }
}