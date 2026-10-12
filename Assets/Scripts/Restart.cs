using UnityEngine;

public class Restart : MonoBehaviour
{
     public Player player;
     public GameObject spawn;
     public Timer timer;
     private Vector2 position;
    void Start()
    {
        position = spawn.transform.position;
    }
    public void Reset(){
    spawn.transform.position = position;
    player.transform.position = spawn.transform.position;
    timer.time = 0;
    }
}
