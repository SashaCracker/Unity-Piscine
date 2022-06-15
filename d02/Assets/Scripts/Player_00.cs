using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player_00 : MonoBehaviour
{
    private bool isMooving = false;
    private Vector3 targetPosition;
    public float speed = 0.5f;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private AudioClip my_lord_sound;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
            SoundManager.Instance.PlaySound(my_lord_sound);
        }
        if (isMooving)
        {
            Move();
        }
    }

    private void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
        isMooving = true;
        if (Mathf.Abs(targetPosition.x - transform.position.x) > Mathf.Abs(targetPosition.y - transform.position.y))
        {
            if (targetPosition.x > transform.position.x)
            {
                spriteRenderer.flipX = false;
                animator.Play("PlayerMoveRight");
            }
            else
            {
                spriteRenderer.flipX = true;
                animator.Play("PlayerMoveRight");
            }
        }
        else
        {
            if (targetPosition.y < transform.position.y)
            {
                animator.Play("PlayerMoveDown");
            }
            else
                animator.Play("PlayerMoveUp");
        }
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (transform.position == targetPosition)
        {
            isMooving = false;
            animator.Play("Stop");
        }
    }
}
