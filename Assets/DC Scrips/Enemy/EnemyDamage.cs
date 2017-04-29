using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

    public int maxHealth = 60;
    public int currentHealth;
    Rigidbody parentBody;
    // Use this for initialization
    void Start () {
        currentHealth = maxHealth;
        parentBody = GetComponentInParent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hit(int damage)
    {
        currentHealth = currentHealth - damage;
        parentBody.AddForce(Vector3.back);

        if (currentHealth <= 0)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
