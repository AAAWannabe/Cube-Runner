using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private Vector2 moveDirection;
    [SerializeField]
    private float moveSpeed = 2f;
    [SerializeField]
    private TextMeshProUGUI scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

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

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Renderer>().material.color == Color.red)
        {
            //cannot use DestroyImmediate
            //Destroy(GetComponent<BoxCollider>());
            Destroy(collision.gameObject);
            scoreText.text = (score += 10).ToString();
        }
        else if (collision.gameObject.tag != "Env")
        {
            Destroy(collision.gameObject);
            scoreText.text = (score -= 10).ToString();
        }
    }

}
