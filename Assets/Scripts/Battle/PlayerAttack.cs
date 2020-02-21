using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{//Mellee Attack
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask WhatIsEnemy;
    public float attackRange;
    public int damage;

    void Update()
    {
        if (timeBtwAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Mouse0)){
                Collider2D[] toDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, WhatIsEnemy);
                for (int i = 0; i < toDamage.Length; i++){
                    toDamage[i].GetComponent<BossBehavior>().takeDamage(damage);//FIX THIS
                }
            }

            timeBtwAttack = startTimeBtwAttack;
        }
        else{
            timeBtwAttack -= Time.deltaTime;

        }   
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
