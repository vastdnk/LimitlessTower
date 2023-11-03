using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Parameters : MonoBehaviour
{
    // Start is called before the first frame update

    
    public string NPC_Name = "Blue toxic agent";
    public int NPC_Level = 1;
    //public float NPC_Health = 10;
    public float NPC_MaxHealth = 10;
    public float NPC_Health = 10f;

    
    public int indicateHealthPoint;




    private void FixedUpdate()
    {
        GameObject hp_indicator = GameObject.FindGameObjectWithTag("Healthpoint_Indicator");
        Slider hp_= hp_indicator.GetComponent<Slider>();

        hp_.minValue = 0;
        hp_.maxValue = NPC_MaxHealth;
        hp_.value = NPC_Health;
    }
}
