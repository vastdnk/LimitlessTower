using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayChanger : MonoBehaviour
{
    public string sceneName;
    public void changeSceneToStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
