using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour {
    
    
    Animator anim;
    altPlayerController playerMovement;
    playerInfo playerStats;
   
    
     

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        
        playerMovement = GetComponent<altPlayerController>();
        if (GetComponent<KnightClass>())
        {
            playerStats = new KnightClass();
        }

        


    }
	
	// Update is called once per frame
	void Update () {
		
	}

   

    public void Hit(int damage)
    {
        playerStats.CurrentHealth = playerStats.CurrentHealth - damage;

        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Hit"))
        {
            anim.Play("Hit");
        }





        print("Hit");
        print(playerStats.CurrentHealth);

        if (playerStats.CurrentHealth <= 0)
        {
            playerMovement.enabled = false;
            anim.Play("Death");
            


        }

        else
        {
            playerMovement.enabled = true;
        }


    }
}
