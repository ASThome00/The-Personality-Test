using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttacks : MonoBehaviour {//Mellee Attack
    private float timeBtwRangedAttack;

    public LayerMask WhatIsEnemyR;

    public float startTimeBtwSniper;
    public Transform SniperPos;
    public float SniperRange;
    public float SniperDamage;
    public float SniperWidth;

    public float startTimeBtwFan;
    public Transform FanPos;
    public float FanRange;
    public float FanDamage;

    void Update() {
        if (PlayerControl.isSniper && timeBtwRangedAttack <= 0) {//Stab Attack
            if (Input.GetKey(KeyCode.Mouse0)) {
                Collider2D[] toDamage = Physics2D.OverlapAreaAll(new Vector2(-(SniperWidth / 2),10), new Vector2((SniperWidth/2),10), WhatIsEnemyR);
                for (int i = 0; i < toDamage.Length; i++) {
                    toDamage[i].GetComponent<BossBehavior>().takeDamage(stabDamage);//FIX THIS
                    Debug.Log("STAB!");
                }

            }
            timeBtwAttack = startTimeBtwStab;
        } else if ((!PlayerControl.isSniper) && timeBtwAttack <= 0) {
            if (Input.GetKey(KeyCode.Mouse0)) {
                Collider2D[] toDamage = Physics2D.OverlapBoxAll(swipePos.position, new Vector2(1,swipeRange),0, WhatIsEnemyR);
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
        Gizmos.DrawWireCube(stabPos.position, new Vector3(SniperWidth,10,0));
    }
}
