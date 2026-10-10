using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    
    [SerializeField] private float Speed = 8f;
    [SerializeField] private float jumpPower = 12f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform feet;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private float maxSpeed = 15f;
    [SerializeField] private float boostInterval = 0.01f; 

    [SerializeField] private CinemachineCamera cam; 
    [SerializeField] private float Camsize = 10f; 
    private Vector2 lastInputDirection;
    private bool isHoldingBoost = false;
    private float boostTimer = 0f;

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(feet.position, groundCheckRadius, groundLayer);
    }

    public void Jump(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
        }
    }

    void Update()
    {
        if (isHoldingBoost)
        {
            boostTimer = boostTimer + Time.deltaTime;
            if (boostTimer >= boostInterval)
            {
                Boost(lastInputDirection);
                boostTimer = 0f; 
            }
        }
    }

    public void Walk(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            lastInputDirection = callbackContext.ReadValue<Vector2>();
            Boost(lastInputDirection);
            isHoldingBoost = true;
            boostTimer = 0f; 
        }
        else if (callbackContext.canceled)
        {
            isHoldingBoost = false;
            boostTimer = 0f;
        }
         else if (callbackContext.performed)
        {
            lastInputDirection = callbackContext.ReadValue<Vector2>();
        }
    }

    private void Boost(Vector2 direction)
    {
        
        if (rb.linearVelocityX < maxSpeed && rb.linearVelocityX > -maxSpeed)
        {
            rb.AddForce(new Vector2(direction.x * Speed, direction.y), ForceMode2D.Impulse);
        }
    }

private bool bigcam = false;
public void BigCamera()
  {
    Debug.Log("fart");
if(!bigcam){
    cam.Lens.OrthographicSize = Camsize;
    bigcam =true;
  }
    else
    {
      cam.Lens.OrthographicSize = 15f;
      bigcam =false;
    }
  }

}