using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movespeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    //input
    //apply movement
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (PauseController.IsGamePaused)
        {
            rb.linearVelocity = Vector2.zero; //stop walk
            return;
        }
        rb.linearVelocity = moveInput * movespeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}