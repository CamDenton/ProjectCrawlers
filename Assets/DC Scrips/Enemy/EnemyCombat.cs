﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour {
    
    
    public int enemyDamage = 10;
    CharacterController controller;
   

    // Use this for initialization
    void Start()
    {
        
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    void OnCollisionEnter(Collision hit)
    {
        
        if (hit.gameObject.tag == "Player")
        {
            hit.gameObject.SendMessageUpwards("Hit", enemyDamage, SendMessageOptions.DontRequireReceiver);
            Debug.Log("Hit");

           
            
        }

    }


     
}
