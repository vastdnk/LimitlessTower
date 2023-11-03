using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine;

public class SlimeLogic : MonoBehaviour
{

    public float speed = 1f;
    Animator animator;
    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
       //hp = GetComponent<NPC_Parameters>();
       animator = GetComponent<Animator>();
       target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    public void Update()
    {
        //if (Vector2.Distance(new Vector2(transform.position.x, transform.position.y), new Vector2(Player.transform.position.x, Player.transform.position.y)) < 6f)
        //    action = 1;
        //else
        //    action = 0;

        //if (action == 0)
        //{
        //    if (point[rand].transform.parent != null)
        //        for (int i = 0; i < point.Length; i++)
        //            point[i].transform.parent = null;
        //    if (transform.position != point[rand].transform.position)
        //        transform.position = Vector3.MoveTowards(transform.position, point[rand].transform.position, speed * Time.deltaTime);
        //    else
        //        rand = UnityEngine.Random.Range(0, 12);
        //}

        if (GetComponent<NPC_Parameters>().NPC_Health <= 0)
        {
            animator.SetBool("isDead", true);
            gameObject.GetComponent<Collider2D>().enabled = false;
            //gameObject.GetComponent<Animator>().enabled = false;
            gameObject.tag = "DeadEnemy";
            Destroy(gameObject, 0.8f);
        }



        if (target != null)
        {
            var step = 2f * Time.deltaTime;
            gameObject.transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
        }

        //Debug.Log(gameObject.GetComponent<NPC_Parameters>().NPC_Health);

        



    }
}
