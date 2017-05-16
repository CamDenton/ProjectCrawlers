using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerAttack : MonoBehaviour {
    public int AttackInt = 30;
    Animator anim;
   public bool hasHit = false;
    public string attackButton = "FireP1";


	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponentInParent<Animator>();
  
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(hasHit);

        
	}

 IEnumerator Attack()
    {
        
        yield return new WaitForSeconds(2);
        hasHit = false;

    }

    void OnTriggerEnter(Collider coll)
    {
        
        if (coll.gameObject.tag == "Enemy" && Input.GetButtonDown(attackButton))

            if(hasHit == false)
        {
                hasHit = true;
                coll.gameObject.BroadcastMessage("Hit", AttackInt, SendMessageOptions.DontRequireReceiver);
                StartCoroutine(Attack());

            }

    }

    void ChangeAttack(int modifier)
    {
        AttackInt += modifier;
    }
}


