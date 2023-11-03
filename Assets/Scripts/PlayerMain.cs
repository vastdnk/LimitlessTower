using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public float speed;
    public DynamicJoystick joystick;
    private Animator animator;


    Rigidbody2D rb;
    Vector2 direction;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        rb.AddForce(direction * speed * Time.deltaTime, ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        if (direction != new Vector2(0, 0))
        {
            if (direction.x > 0f)
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if (direction.x < 0f)
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (animator.GetInteger("Direction") == 0)
            {
                animator.SetInteger("Direction", 1);
            }
        }
        else
        {
            animator.SetInteger("Direction", 0);
        }
    }
}
