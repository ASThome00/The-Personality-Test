using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurveyScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ss;
    public GameObject q1;
    public GameObject q2;
    public GameObject q3;
    public GameObject q4;
    public GameObject q5;
    public GameObject q6;
    public GameObject q7;
    public GameObject q8;
    public GameObject q9;
    public GameObject q10;
    public GameObject q11;
    public GameObject q12;
    public static int[] choices = { 0, 0, 0, 0 };
    void Start()
    {
        ss = GameObject.Find("SurveyStart");
        q1 =GameObject.Find("Question1");
        q2 = GameObject.Find("Question2");
        q3 = GameObject.Find("Question3");
        q4 = GameObject.Find("Question4");
        q5 = GameObject.Find("Question5");
        q6 = GameObject.Find("Question6");
        q7 = GameObject.Find("Question7");
        q8 = GameObject.Find("Question8");
        q9 = GameObject.Find("Question9");
        q10 = GameObject.Find("Question10");
        q11 = GameObject.Find("Question11");
        q12 = GameObject.Find("Question12");
        q1.SetActive(false);
        q2.SetActive(false);
        q3.SetActive(false);
        q4.SetActive(false);
        q5.SetActive(false);
        q6.SetActive(false);
        q7.SetActive(false);
        q8.SetActive(false);
        q9.SetActive(false);
        q10.SetActive(false);
        q11.SetActive(false);
        q12.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void NextButtonClick()
    {
        ss.SetActive(false);
        q1.SetActive(true);
        AudioScript.playClick();
    }

    public void q1YesClick()
    {
        q1.SetActive(false);
        q2.SetActive(true);
        choices[0]++;
        AudioScript.playClick();
    }

    public void q1NoClick()
    {
        q1.SetActive(false);
        q2.SetActive(true);
        AudioScript.playClick();
    }

    public void q2YesClick()
    {
        q2.SetActive(false);
        q3.SetActive(true);
        choices[0]++;
        AudioScript.playClick();
    }

    public void q2NoClick()
    {
        q2.SetActive(false);
        q3.SetActive(true);
        AudioScript.playClick();
    }

    public void q3YesClick()
    {
        q3.SetActive(false);
        q4.SetActive(true);
        choices[0]++;
        AudioScript.playClick();
    }

    public void q3NoClick()
    {
        q3.SetActive(false);
        q4.SetActive(true);
        AudioScript.playClick();
    }

    public void q4YesClick()
    {
        q4.SetActive(false);
        q5.SetActive(true);
        choices[1]++;
        AudioScript.playClick();
    }

    public void q4NoClick()
    {
        q4.SetActive(false);
        q5.SetActive(true);
        AudioScript.playClick();
    }

    public void q5YesClick()
    {
        q5.SetActive(false);
        q6.SetActive(true);
        choices[1]++;
        AudioScript.playClick();
    }

    public void q5NoClick()
    {
        q5.SetActive(false);
        q6.SetActive(true);
        AudioScript.playClick();
    }

    public void q6YesClick()
    {
        q6.SetActive(false);
        q7.SetActive(true);
        choices[1]++;
        AudioScript.playClick();
    }

    public void q6NoClick()
    {
        q6.SetActive(false);
        q7.SetActive(true);
        AudioScript.playClick();
    }

    public void q7YesClick()
    {
        q7.SetActive(false);
        q8.SetActive(true);
        choices[2]++;
        AudioScript.playClick();
    }

    public void q7NoClick()
    {
        q7.SetActive(false);
        q8.SetActive(true);
        AudioScript.playClick();
    }

    public void q8YesClick()
    {
        q8.SetActive(false);
        q9.SetActive(true);
        choices[2]++;
        AudioScript.playClick();
    }

    public void q8NoClick()
    {
        q8.SetActive(false);
        q9.SetActive(true);
        AudioScript.playClick();
    }

    public void q9YesClick()
    {
        q9.SetActive(false);
        q10.SetActive(true);
        choices[2]++;
        AudioScript.playClick();
    }

    public void q9NoClick()
    {
        q9.SetActive(false);
        q10.SetActive(true);
        AudioScript.playClick();
    }

    public void q10YesClick()
    {
        q10.SetActive(false);
        q11.SetActive(true);
        choices[3]++;
        AudioScript.playClick();
    }

    public void q10NoClick()
    {
        q10.SetActive(false);
        q11.SetActive(true);
        AudioScript.playClick();
    }
    public void q11YesClick()
    {
        q11.SetActive(false);
        q12.SetActive(true);
        choices[3]++;
        AudioScript.playClick();
    }

    public void q11NoClick()
    {
        q11.SetActive(false);
        q12.SetActive(true);
        AudioScript.playClick();
    }
    public void q12YesClick()
    {
        q12.SetActive(false);
        choices[3]++;
        SceneManager.LoadScene("CharacterSheet");
        AudioScript.playClick();
    }

    public void q12NoClick()
    {
        q12.SetActive(false);
        SceneManager.LoadScene("CharacterSheet");
        AudioScript.playClick();
    }
}
