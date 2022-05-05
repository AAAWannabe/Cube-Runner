using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    
    private Vector2 moveDirection;
    [SerializeField]
    private float moveSpeed = 2f;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

    void Move(Vector2 direction)
    {
        //only move horizontally
        transform.Translate(direction.x * moveSpeed * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Move(moveDirection);
        //set plane static, only let cube move
    }

    
}
