using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateIndustry : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Floor_Industry;
    public int columns;
    public int rows;



    public void Awake()
    {
        int x = -400;
        int y = 400;
        for (int i = 0; i < columns; i++)
        {
            x = x + 2;
            //y = y - 2;
            //Debug.Log(x);
            Instantiate(Floor_Industry);
            Floor_Industry.transform.position = new Vector3(((x + 2) * 1.75f), y, 0);

            for (int j = 0; i < rows; j++)
            
                y = y - 2;
                Instantiate(Floor_Industry);
                Floor_Industry.transform.position = new Vector3(((x + 2) * 1.75f), y * 1.75f, 0);
            }
            
         
        
    }
}
