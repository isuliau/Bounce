using UnityEditor.Build;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{

  [SerializeField]  private Rigidbody2D rb;
     [SerializeField]   private float Speed = 500f;
    [SerializeField] private float upforce = 1000f;
    public LayerMask GroundLayer;
   [SerializeField] private bool floored = true; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(GroundLayer == (1 << collision.gameObject.layer))
        {
            floored = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
     
    }
     void FixedUpdate()
    {
    
    }
    public void Jump(InputAction.CallbackContext callbackContext)
    {
      if(callbackContext.performed && floored){  
        rb.AddForce(Vector2.up * upforce);
     floored = false;
    }
    }
    public void Walk(InputAction.CallbackContext callbackContext)
    {
      Vector2 input = callbackContext.ReadValue<Vector2>();
    Debug.Log(input);
    rb.AddForce(new Vector2 (input.x, input.y) * Speed);
    }
    }

