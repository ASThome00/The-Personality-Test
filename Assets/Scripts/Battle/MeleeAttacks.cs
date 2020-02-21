using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttacks : MonoBehaviour {//Mellee Attack
    private float timeBtwAttack;

    public LayerMask WhatIsEnemy;

    public float startTimeBtwStab;
    public Transform stabPos;
    public float stabRange;
    public float stabDamage;

    public float startTimeBtwSwipe;
    public Transform swipePos;
    public float swipeRange;
    public float swipeDamage;


    void Update() {
        if (PlayerControl.isStab && timeBtwAttack <= 0) {//Stab Attack
            if (Input.GetKey(KeyCode.Mouse0)) {
                Collider2D[] toDamage = Physics2D.OverlapCircleAll(stabPos.position, stabRange, WhatIsEnemy);
                for (int i = 0; i < toDamage.Length; i++) {
                    toDamage[i].GetComponent<BossBehavior>().takeDamage(stabDamage);//FIX THIS
                    Debug.Log("STAB!");
                }

            }
            timeBtwAttack = startTimeBtwStab;
        } else if ((!PlayerControl.isStab) && timeBtwAttack <= 0) {
            if (Input.GetKey(KeyCode.Mouse0)) {
                Collider2D[] toDamage = Physics2D.OverlapCircleAll(swipePos.position, swipeRange, WhatIsEnemy);
                for (int i = 0; i < toDamage.Length; i++) {
                    toDamage[i].GetComponent<BossBehavior>().takeDamage(swipeDamage);//FIX THIS
                    Debug.Log("SWIPE!");
                }

            }
            timeBtwAttack = startTimeBtwSwipe;


        } else {
            timeBtwAttack -= Time.deltaTime;
        }
    }
    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(stabPos.position, stabRange);
        Gizmos.DrawWireSphere(swipePos.position, swipeRange);
    }
}
