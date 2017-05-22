using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerAttack : MonoBehaviour {
    public int AttackInt;
    Animator anim;
   public bool hasHit = false;
    public string attackButton = "FireP1";
    public PlayerStats stats;


	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponentInParent<Animator>();
        stats = gameObject.GetComponentInParent<PlayerStats>();
        
  
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(hasHit);
        Debug.Log(AttackInt);

        
	}

    private void FixedUpdate()
    {
        AttackInt = stats.playerClassType.Attack;
    }

    public void Hit()
    {

        Debug.Log("I have hit");
        hasHit = true;

    }

   public void AEnd()
    {
        hasHit = false;
    }

    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "Enemy" && hasHit == true)


        {
            
            coll.gameObject.BroadcastMessage("Hit", AttackInt, SendMessageOptions.DontRequireReceiver);
            Debug.Log("Trigger Hit");
            AEnd();

        }
            

    }

    void ChangeAttack(int modifier)
    {
        AttackInt += modifier;
    }
}


