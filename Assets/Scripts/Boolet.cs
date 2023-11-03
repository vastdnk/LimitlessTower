using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Boolet : Weapon
{
    public NPC_Parameters npcParam;

    public GameObject hitEffect;
    public float booletDmg = 1f;
    public float hp;

    public void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //hp = otherCollider.GameObject().GetComponent<NPC_Parameters>().NPC_Health;

        //hp = collision.collider.gameObject.GetComponent<NPC_Parameters>().NPC_Health;

        //Debug.Log(hp);
        
        

        if (collision.collider.gameObject.GameObject().CompareTag("Enemy"))
        {
            hp = collision.collider.gameObject.GetComponent<NPC_Parameters>().NPC_Health;


            float newHP = hp - Random.Range(booletDmg, 5);

            
            collision.collider.gameObject.GetComponent<NPC_Parameters>().NPC_Health = newHP;

            //Debug.Log(hp);

            //Debug.Log(collision.collider.gameObject.GetComponent<NPC_Parameters>().NPC_Health);

            
        }

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.25f);
        Destroy(gameObject);

    }
}
