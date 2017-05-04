using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerAttack : MonoBehaviour {
    public int AttackInt = 30;
    Animator anim;
   public bool isAttacking = false;


	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponentInParent<Animator>();
  
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(isAttacking);
        if (Input.GetButtonDown("Fire1") && !isAttacking)
        {
            StartCoroutine(Attack());
        }
        
	}

 IEnumerator Attack()
    {
        isAttacking = true;
        yield return new WaitForSeconds(1);
        isAttacking = false;

    }

    void OnTriggerEnter(Collider coll)
    {
        
        if (coll.gameObject.tag == "Enemy" && isAttacking)
        {
            coll.gameObject.BroadcastMessage("Hit", AttackInt, SendMessageOptions.DontRequireReceiver);
            
        }

    }

    void ChangeAttack(int modifier)
    {
        AttackInt += modifier;
    }
}


