using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour {
    
    
    Animator anim;
    PlayerMov playerMovement;
    playerInfo playerStats;
    CharacterController controller;
   
    
     

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        playerMovement = GetComponent<PlayerMov>();
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
            controller.Move(controller.transform.forward * -5);

        }





        print("Hit");
        print(playerStats.CurrentHealth);

        if (playerStats.CurrentHealth <= 0)
        {
            playerMovement.enabled = false;
            anim.Play("Death");
            Application.Quit();
            


        }

        else
        {
            playerMovement.enabled = true;
        }


    }
}
