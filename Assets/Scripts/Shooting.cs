using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Shooting : MonoBehaviour
{
    public Player player;
    public GameObject nearestEnemy;

    public Transform firePoint;
    public GameObject bulletPrefab;
    public DynamicJoystick joystick;
    public float bulletForce = 20f;
    //public float turnSpeed;

    public GameObject targetObj;
    public string viewedName;
    public int viewedLVL;
    public float healthPoints, maxHealthPoints;


    public Transform target;

    public GameObject weapon;
    public Vector2 movementInput;

    void Start()
    {
        
    }

    // Update is called once per frame
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
                targetObj = enemy;
            }
        }

        GameObject info = GameObject.FindGameObjectWithTag("NPC_Info");
        //info.ToString();
        info.GetComponent<Text>().text = viewedName + ", " + viewedLVL + " LVL";
        GameObject infoIndicator = GameObject.FindGameObjectWithTag("Healthpoint_Indicator");

        infoIndicator.GetComponent<UnityEngine.UI.Slider>().maxValue = maxHealthPoints;
        infoIndicator.GetComponent<UnityEngine.UI.Slider>().value = healthPoints;


    }



    public void Shoot()
    {

         GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
         Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
         rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
  
    }


    void FixedUpdate()
    {
        //SpriteRenderer sr = weapon.GetComponent<SpriteRenderer>();
        //movementInput = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;

        if (target != null)
        {
            Vector3 difference = target.position - transform.position;

            float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg - 90f;
            weapon.transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);

            
            if (player.transform.localScale.x > 0)
            {
                weapon.transform.localScale = new Vector3(1, 1, 1);
                //player.transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (player.transform.localScale.x < 0)
            {
                weapon.transform.localScale = new Vector3(1, 1, 1);
                //player.transform.localScale = new Vector3(1, 1, 1);
            }


            viewedName = targetObj.GetComponent<NPC_Parameters>().NPC_Name;
            viewedLVL= targetObj.GetComponent<NPC_Parameters>().NPC_Level;
            healthPoints = targetObj.GetComponent<NPC_Parameters>().NPC_Health;
            maxHealthPoints = targetObj.GetComponent<NPC_Parameters>().NPC_MaxHealth;



        }
 


    }
}
