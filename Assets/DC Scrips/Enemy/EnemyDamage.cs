using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour {

    public int maxHealth = 60;
    public int currentHealth;
    Rigidbody parentBody;
    public Slider healthBar;
    GameObject thisEnemy;
    
    // Use this for initialization
    void Start () {
        currentHealth = maxHealth;
        parentBody = GetComponentInParent<Rigidbody>();
        thisEnemy = gameObject; 

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(currentHealth);
    }

    public void Hit(int damage)
    {
        currentHealth = currentHealth - damage;
        parentBody.AddForce(Vector3.back);
        Debug.Log("Enemy hit");

        if (currentHealth <= 0)
        {
            Destroy(transform.parent.gameObject);
            SendMessageUpwards("RemoveSpawn", thisEnemy);
        }
    }
}
