using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;



//[RequireComponent(typeof(BoxCollider2D))]

public class Player : MonoBehaviour
{
    [SerializeField] private int PlayerHealth;

    public Animator animator;
    public DynamicJoystick joystick;
    public ContactFilter2D movementFilter;
    public float speed = 0f;

    GameObject nearestEnemy;
    Transform target;

    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    public Vector2 movementInput;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        FindNearestEnemy();
    }

    void FindNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy"); // поиск всех объектов с тегом "Enemy"

        float shortestDistance = Mathf.Infinity;
        nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                target = enemy.transform;
            }
        }
    }

    private void FixedUpdate()
    {
        movementInput = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        rb.AddForce(movementInput * speed * Time.deltaTime, ForceMode2D.Impulse);

        if (movementInput != Vector2.zero)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }


        if (target == null)
        {
            if (movementInput.x > 0)
            {
                transform.localScale = Vector3.one;
                //spriteRenderer.flipX = true;
            }
            else if (movementInput.x < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                //spriteRenderer.flipX = false;
            }
        }


        if (target != null)
        {
            if (target.position.x < gameObject.transform.position.x)
            {

                transform.localScale = new Vector3(-1, 1, 1);
                //if (movementInput.x > 0)
                //{
                //    transform.localScale = Vector3.one;
                //    //spriteRenderer.flipX = true;
                //}
                //else if (movementInput.x < 0)
                //{
                //    transform.localScale = new Vector3(-1, 1, 1);
                //    //spriteRenderer.flipX = false;
                //}
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
        

    }


    // Update is called once per frame
    

}
