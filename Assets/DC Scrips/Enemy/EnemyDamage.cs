using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyDamage : MonoBehaviour {

    public int maxHealth = 60;
    public int currentHealth;
    Rigidbody parentBody;
    public Slider healthBar;
    GameObject thisEnemy;
    NavMeshAgent agent; 
    
    // Use this for initialization
    void Start () {
        currentHealth = maxHealth;
        parentBody = GetComponentInParent<Rigidbody>();
        thisEnemy = gameObject;
        agent = GetComponentInParent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(currentHealth);
    }

    public void Hit(int damage)
    {
        currentHealth = currentHealth - damage;
        parentBody.AddRelativeForce(Vector3.back * 10, ForceMode.Force);
        agent.Move(agent.transform.forward * -3); 
        Debug.Log("Enemy hit");

        if (currentHealth <= 0)
        {
            SendMessageUpwards("RemoveSpawn", SendMessageOptions.DontRequireReceiver);
            Destroy(transform.parent.gameObject);
            
        }
    }
}
