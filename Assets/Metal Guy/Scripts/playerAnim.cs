using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnim : MonoBehaviour {
    Animator anim;
    public string horizontal = "HorizontalP1";
    public string vertical = "VerticalP1";
    public string sprint = "SprintP1";
    // Use this for initialization
    void Start () {
        anim = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis(vertical) > 0)
        {
            anim.SetBool("Forward", true);
            anim.SetBool("Backward", false);
        }

      

        if(Input.GetAxis(vertical) < 0)
        {
            anim.SetBool("Forward", false);
            anim.SetBool("Backward", true);
        }

        if(Input.GetAxis(vertical) < 1 & Input.GetAxis(vertical) > -1)
        {
            anim.SetBool("Forward", false);
            anim.SetBool("Backward", false);
        }

        if(Input.GetAxis(horizontal) < 0)
        {
            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
        }

        if (Input.GetAxis(horizontal) > 0)
        {
            anim.SetBool("Left", false);
            anim.SetBool("Right", true);
        }

        if (Input.GetAxis(horizontal) < 1 && Input.GetAxis(horizontal) > -1)
        {
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }

        if (Input.GetButton(sprint) && Input.GetAxis(vertical) > 0)
        {
            anim.SetBool("Sprinting", true); 
        }

        else
        {
            anim.SetBool("Sprinting", false);
        }

        if (!Input.GetButton(sprint) && Input.GetAxis(vertical) < 1)
        {
            anim.SetBool("Sprinting", false);
        }

        if (Input.GetButtonDown("Fire1") && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            anim.SetBool("Main Attack", true);
        }

        if(!Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("Main Attack", false);
        }

    }
}
