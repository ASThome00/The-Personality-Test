using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed, rSpeed;
    public float health = 100f;
    private Rigidbody2D rb;
    public static bool isStab = true;
    public static bool isSniper = true;
    public int consume = 1;

    // Start is called before the first frame update
    void Start()
    {
        if(SurveyScripts.choices[2] >= 2)
        {
            isStab = false;
        }
        rb = gameObject.GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Player::Start cant find RigidBody2D </sadface>");
        }
    }
    // Update is called once per frame
    void Update() { 
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rSpeed * Time.deltaTime);

        if(health <= 0)
        {
            SceneManager.LoadScene("DefeatEnding");
        }

        GameObject.Find("Main Camera/HUD/Health").GetComponent<TextMeshProUGUI>().text = "Health: " + health.ToString();
    }

    // this is called at a fixed interval for use with physics objects like the RigidBody2D
    void FixedUpdate()
    {
        // check if user has pressed some input keys
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            Debug.Log(Input.GetAxisRaw("Horizontal"));
            // convert user input into world movement
            float horizontalMovement = Input.GetAxisRaw("Horizontal") * moveSpeed;
            float verticalMovement = Input.GetAxisRaw("Vertical") * moveSpeed;

            //assign world movements to a Veoctor2
            Vector2 directionOfMovement = new Vector2(horizontalMovement, verticalMovement);

            // apply movement to player's transform
            rb.velocity = directionOfMovement;
        }
        if (Input.GetAxisRaw("Horizontal") == 0)
        {//stop velocity if key is no longer pressed
            Vector3 v = rb.velocity;
            v.x = 0;
            rb.velocity = v;
        }
        if (Input.GetAxisRaw("Vertical") == 0)
        {//stop velocity if key is no longer pressed
            Vector3 v = rb.velocity;
            v.y = 0;
            rb.velocity = v;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //put ranged attack code here
            Debug.Log("Ranged attack");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //put defense move code here
            Debug.Log("defense move");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //put consumable code here
            Debug.Log("Consume");
            if(consume > 0)
            {
                health += 20;
                consume--;
            }
        }
    }

    public void takeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Took" + damage + "Damage");
    }
}
