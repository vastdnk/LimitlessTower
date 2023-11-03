using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Weapon : MonoBehaviour
{
    public int weaponType;
    public string weaponName;
    public int weaponLevel;
    public int weaponGearScore;
    public int weaponQuality;
    public float reloadTime;
}


















    //public int damagePoint = 1;
    //private float pushForse = 2.0f;
    //public int weaponLevel = 0;
    //private SpriteRenderer spriteRenderer;

    ////public Button actionTrigger;


    ////Взмах
    //private float cooldown = 0.5f;
    //private float lastSwing;


    //// Start is called before the first frame update
    //protected override void Start()
    //{
    //    base.Start();
    //    spriteRenderer = GetComponent<SpriteRenderer>();

    //}

    //// Update is called once per frame
    //protected override void Update()
    //{
    //    base.Update();



    //    if (Input.GetKeyUp(KeyCode.Escape))
    //    {
    //        if (Time.time - lastSwing > cooldown)
    //        {
    //            lastSwing = Time.time;
    //            Swing();
    //        }
    //    }
    //}

    //protected override void OnCollide(Collider2D coll)
    //{
    //    //Debug.Log(coll.name);


    //    if (coll.tag == "Enemy")
    //    {
    //        if (coll.name == "Player")
    //            return;

    //        Debug.Log(coll.name);

    //    }
    //}

    //private void Swing()
    //{
    //    Debug.Log("Swing");
    //}


    //Player player;
    //public float range = 5f; // дальность атаки
    //public Transform target; // цель
    //GameObject nearestEnemy;
    //Rigidbody2D rb;

    //void Update()
    //{
    //FindNearestEnemy(); // поиск ближайшего врага

    //if (target != null && Vector2.Distance(transform.position, target.position) <= range)
    //{
    //    Attack(); // атака при наличии цели и достаточной дистанции до нее
    //}
    //else
    //{
    //    float rotateA = Mathf.Atan2(player.movementInput.y, player.movementInput.x) * Mathf.Rad2Deg;
    //    gameObject.transform.rotation = Quaternion.Euler(0f, 0f, rotateA);
    //}
    //}

    //void FindNearestEnemy()
    //{
    //    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy"); // поиск всех объектов с тегом "Enemy"

    //    float shortestDistance = Mathf.Infinity;
    //    nearestEnemy = null;

    //    foreach (GameObject enemy in enemies)
    //    {
    //        float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
    //        if (distanceToEnemy < shortestDistance)
    //        {
    //            shortestDistance = distanceToEnemy;
    //            target = enemy.transform;
    //        }
    //    }
    //}

    //void Attack()
    //{

    //    Debug.Log("Attacking: " + target.name);
    //    Vector3 difference = target.transform.position - transform.position;
    //    float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

    //    gameObject.transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);

    //    /* здесь можно добавить код для нанесения урона или других эффектов */
    //}





















