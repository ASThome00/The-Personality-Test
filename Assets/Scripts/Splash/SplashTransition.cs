using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashTransition : MonoBehaviour
{
    [SerializeField]
    private float delay = 0.5f;

    private float timer = 0.0f;
    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > delay)
        {
            Debug.Log("Load Main Menu");
            SceneManager.LoadScene("MainMenu");
        }
    }
}
