using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnim : MonoBehaviour {
    Animator anim; 
	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w"))
        {
            anim.SetBool("Forward", true);
            anim.SetBool("Backward", false);
        }

      

        if(Input.GetKey("s"))
        {
            anim.SetBool("Forward", false);
            anim.SetBool("Backward", true);
        }

        if(Input.GetKey("w")== false & Input.GetKey("s")== false)
        {
            anim.SetBool("Forward", false);
            anim.SetBool("Backward", false);
        }

        if(Input.GetKey("a"))
        {
            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
        }

        if (Input.GetKey("d"))
        {
            anim.SetBool("Left", false);
            anim.SetBool("Right", true);
        }

        if (Input.GetKey("a") == false & Input.GetKey("d") == false)
        {
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }

        if (Input.GetKey("left ctrl") & Input.GetKey("w"))
        {
            anim.SetBool("Sprinting", true); 
        }

        else
        {
            anim.SetBool("Sprinting", false);
        }

        if (Input.GetKey("left ctrl") == false & Input.GetKey("w"))
        {
            anim.SetBool("Sprinting", false);
        }

        if (Input.GetMouseButtonDown(0) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetBool("Main Attack", true);
        }

        if(!Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Main Attack", false);
        }

    }
}
