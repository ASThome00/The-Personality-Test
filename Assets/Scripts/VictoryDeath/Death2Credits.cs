using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death2Credits : MonoBehaviour
{ 
    public void goToCredits()
    {
        //Application.Quit();
        SceneManager.LoadScene("Credits");
    }
}
