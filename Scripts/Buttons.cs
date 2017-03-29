using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void MENU_ACTION_LoadDemo_GamePlaying() // method to call inside unity
    {
        SceneManager.LoadScene("Demo");  // load the scene inside the brackets
    }
}