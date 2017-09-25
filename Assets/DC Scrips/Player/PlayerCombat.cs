using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour {

    playerAnim pAnims;
    Animator anim;
    PlayerMov playerMovement;
    PlayerStats playerStats;
    CharacterController controller;
    public Slider healthBar;
    public Image damagedImage;
   
    
     

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        playerMovement = GetComponent<PlayerMov>();
        playerStats = GetComponent<PlayerStats>();
        playerStats.CurrentHealth = playerStats.MaxHealth;
        pAnims = GetComponent<playerAnim>();

        


    }
	
	// Update is called once per frame
	void Update () {
        healthBar.value = playerStats.CurrentHealth;
        Debug.Log(playerStats.playerClassType + " This is the players class");
       
        
	}

   

    public void Hit(int damage)
    {
        playerStats.CurrentHealth = playerStats.CurrentHealth - damage;

        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Hit"))
        {
            anim.Play("Hit");
            controller.Move(controller.transform.forward * -10);

        }

        print("Hit");
        print(playerStats.CurrentHealth);

        if (playerStats.CurrentHealth <= 0)
        {
            Death();
  
        }

        else
        {
           
        }

    }

    void Death()
    {
        playerMovement.enabled = false;
        anim.SetBool("Dead", true);
        anim.Play("Death");
        pAnims.enabled = false;
        
    }
}
