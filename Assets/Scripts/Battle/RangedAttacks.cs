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
            if (Input.GetKey(KeyCode.Mouse1)) {
                RaycastHit2D contact = Physics2D.Raycast(SniperPos.position, new Vector2(Input.mousePosition.x, Input.mousePosition.y));
                contact.collider.GetComponent<BossBehavior>().takeDamage(SniperDamage);
                Debug.Log("SNIPED");
              
                timeBtwRangedAttack = startTimeBtwSniper;
            }
        } else if ((!PlayerControl.isSniper) && timeBtwRangedAttack <= 0) {
            if (Input.GetKey(KeyCode.Mouse0)) {
               // Collider2D[] toDamage = Physics2D.OverlapBoxAll(swipePos.position, new Vector2(1,swipeRange),0, WhatIsEnemyR);
                //for (int i = 0; i < toDamage.Length; i++) {
                    //toDamage[i].GetComponent<BossBehavior>().takeDamage(swipeDamage);//FIX THIS
                    Debug.Log("FAN");
                //}

            }
            timeBtwRangedAttack = startTimeBtwFan;


        } else {
            timeBtwRangedAttack -= Time.deltaTime;
        }
    }
    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(SniperPos.position, new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }
}
