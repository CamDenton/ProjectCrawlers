using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMov : MonoBehaviour {

    public float speed;
    public float currentSpeed; 
    CharacterController controller;
    float translation = 0f;
    float strafe = 0f;
    public string horizontal = "HorizontalP1";
    public string vertical = "VerticalP1";
    public string sprint = "SprintP1";

    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
        currentSpeed = speed;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;


    }
	
	// Update is called once per frame
	void Update () {
        Vector3 fwd = Input.GetAxis(vertical) * transform.TransformDirection(Vector3.forward);
        Vector3 right = Input.GetAxis(horizontal) * transform.TransformDirection(Vector3.right);

        controller.SimpleMove(Physics.gravity);
        //controller.Move(fwd * Time.deltaTime * currentSpeed);
        //controller.Move(right * Time.deltaTime * currentSpeed);
        strafe = Input.GetAxis(horizontal) * Time.deltaTime * currentSpeed;
        translation = Input.GetAxis(vertical) * Time.deltaTime * currentSpeed;
        transform.Translate(strafe, 0, translation);

        speed = Mathf.Clamp(speed, 0, 16);


        if (Input.GetButton(sprint) && Input.GetAxis(vertical) > 0)
        {
            Sprint();
        }

        else
        {
            currentSpeed = speed;
        }

        
		
	}

    public void Sprint()
    {
        currentSpeed = speed * 2; 
      
    }
}
