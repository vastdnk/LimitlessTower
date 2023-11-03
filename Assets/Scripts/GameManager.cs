using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake() 
    { 
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    //Resourses
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    //References

    public Player player;

    //Public weapon
    public FloatingTextManager floatingTextManager;

    //Logic
    public int copper;
    public int experience;

    //Floating text
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }


    //Save state
    /*
     * int preferedSkin
     * int copper
     * int experience
     * int weaponLevel 
     */
    public void SaveState()
    {
        //Debug.Log("SaveState");

        string s = "";

        s += "0" + "|";
        s += copper.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0";

        PlayerPrefs.SetString("saveState", s);
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {

        if (!PlayerPrefs.HasKey("SaveState"));
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        copper = int.Parse(data[1]);
        experience = int.Parse(data[2]);




        Debug.Log("LoadState");
    }
}
