using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex01 : MonoBehaviour
{
    [HideInInspector] public bool activation;
    public Rigidbody2D rb;
    public float speed;
    public float jump_speed;
    public float hight_limit;
    private bool isGrounded;
    private float _horizontalMovement;
    [HideInInspector] public int game_over;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        game_over = 0;
    }

    private void FixedUpdate()
    {
       rb.velocity = new Vector2(_horizontalMovement * Time.fixedDeltaTime * speed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (activation == true)
        {
            _horizontalMovement = Input.GetAxisRaw("Horizontal");
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded == true)
                    rb.velocity = new Vector2(0, hight_limit * jump_speed);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("floor") && collider.CompareTag("Player"))
            isGrounded = true;
        else if (collider.CompareTag("Player"))
            isGrounded = true;
        else if (collider.CompareTag("floor"))
            isGrounded = true;
        if (collider.CompareTag(name + "exit"))
            game_over = 1;
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("floor") && collider.CompareTag("Player"))
            isGrounded = true;
        else if (collider.CompareTag("Player"))
            isGrounded = true;
        else if (collider.CompareTag("floor"))
            isGrounded = true;
        if (collider.CompareTag(name + "exit"))
            game_over = 1;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("floor") && collider.CompareTag("Player"))
            isGrounded = false;
        else if (collider.CompareTag("Player"))
            isGrounded = false;
        else if (collider.CompareTag("floor"))
            isGrounded = false;
    }
}
