using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossBehavior : MonoBehaviour
{
    private Rigidbody2D boss;
    private Transform player;
    private float health = 100;
    private bool isAttacking = false;
    public float timer, timer2;
    public PlayerControl other;
    public Sprite attackSprite, movementSprite, electricSprite;

    public float rSpeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerObject").transform;
        other = GameObject.FindObjectOfType(typeof(PlayerControl)) as PlayerControl;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (health <= 0)
        {
            Debug.Log("Dead");
            SceneManager.LoadScene("VictoryScreen");
        }
        GameObject.Find("BossBar").GetComponent<Image>().fillAmount = (health / 100);
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rSpeed * Time.deltaTime);

        if (!isAttacking)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, 0.15f);
        }
        if(timer >= 5)
        {
            beginClaw();
        }
        if(timer >= 12)
        {
            isAttacking = false;
            timer = 0;
            this.GetComponent<SpriteRenderer>().sprite = movementSprite;
        }
        if(timer2 >= 30)
        {
            electrify();
        }
        if(timer2 > 40)
        {
            timer2 = 0;
            this.GetComponent<SpriteRenderer>().sprite = movementSprite;
        }
    }
    public void takeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Took" + damage + "Damage");
    }

    public void beginClaw()
    {
        this.GetComponent<SpriteRenderer>().sprite = attackSprite;
        isAttacking = true;
        claw();
    }

    public void claw()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if(timer >= 6)
        {
            if(distance < 10)
            {
                this.GetComponent<SpriteRenderer>().sprite = movementSprite;
                other.takeDamage(10);
                isAttacking = false;
                timer = 0;
            }
        }
    }

    public void electrify()
    {
        isAttacking = true;
        this.GetComponent<SpriteRenderer>().sprite = electricSprite;
        transform.position = Vector3.MoveTowards(transform.position, player.position, 0.25f);
        if (Vector3.Distance(transform.position, player.position) < 7)
        {
            other.takeDamage(1);
        }
    }
}
