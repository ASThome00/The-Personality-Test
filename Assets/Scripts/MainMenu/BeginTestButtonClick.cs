using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginTestButtonClick : MonoBehaviour
{
    public void OnButtonPress()
    {
        //AudioScript.playClick();
        Debug.Log("Test Began");
        SceneManager.LoadScene("Survey");
    }
}
