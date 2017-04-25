using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAttack : MonoBehaviour {
    int AttackInt = 30;
    Animator anim;
    bool attacking = false;
    
   


	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponentInParent<Animator>();
        
        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider coll)
    {
        
        if (coll.gameObject.tag == "Enemy" /*&& Input.GetButton("Fire1")*/)
        {
            coll.gameObject.BroadcastMessage("Hit", AttackInt);
            attacking = true;

        }

    }

    void OnTriggerExit(Collider coll)
    {
        attacking = false;
    }
}


