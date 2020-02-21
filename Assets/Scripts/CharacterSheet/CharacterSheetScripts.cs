using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSheetScripts : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SurveyScripts.choices[0]);
        Debug.Log(SurveyScripts.choices[1]);
        Debug.Log(SurveyScripts.choices[2]);
        Debug.Log(SurveyScripts.choices[3]);
        //greater than or equal to 2 is true

        player = new Player(SurveyScripts.choices[0], SurveyScripts.choices[1], SurveyScripts.choices[2], SurveyScripts.choices[3]);
        Text textRef = GameObject.Find("Attack Info").GetComponent<Text>();
        textRef.text = ("Melee Attack: " + player.getMelee() + "\nGood luck operative!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToBattleClick()
    {
        SceneManager.LoadScene("Battle");
    }


}
