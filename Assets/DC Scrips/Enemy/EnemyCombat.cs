using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour {
    int maxHealth = 60;
    public int currentHealth;
    public int enemyDamage = 10;
    CharacterController controller;

    // Use this for initialization
    void Start()
    {
        currentHealth = maxHealth;
        controller = GetComponent<CharacterController>();
       

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(currentHealth);

    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        if (hit.gameObject.tag == "Player")
        {
            hit.gameObject.BroadcastMessage("Hit", enemyDamage);
            Debug.Log("Hit");
        }
    }

    public void Hit(int damage)
    {
        currentHealth = currentHealth - damage;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

     
}
