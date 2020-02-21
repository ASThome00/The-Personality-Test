using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory2Credits : MonoBehaviour
{ 
    public void goToCredits()
    {
        //Application.Quit();
        SceneManager.LoadScene("Credits");
        Debug.Log("fuck");
    }
}
