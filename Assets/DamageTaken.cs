using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTaken : MonoBehaviour
{
    public Animator damageAnim;

    void Update(){
        if(Zombie.isDamageTaken){
            Zombie.isDamageTaken = false;
            StartCoroutine(Damage());
        }
    }

    public IEnumerator Damage(){
        damageAnim.SetBool("isDamage", false);
        damageAnim.SetBool("isDamage", true);
        yield return new WaitForSeconds(1f);
        damageAnim.SetBool("isDamage", false);
    }
}
