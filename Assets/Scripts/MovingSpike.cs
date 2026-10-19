using System.Drawing;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class MovingSpike : MonoBehaviour
{
    public Transform pointB;
    public float speed = 1.0f;
    private Vector3 pointA;
    public float f;
   void Start()
    {pointA = transform.position;}

    void Update(){
    f = f + Time.deltaTime;
    float t = Mathf.PingPong(f * speed, 1f);
    transform.position = Vector3.Lerp(pointA, pointB.position, t);
    }
}