using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
   public GameObject enemyObject;
    Vector3 parentPosition;
    public int maxSpawn = 0;
    

	// Use this for initialization
	void Start () {
        parentPosition = gameObject.transform.position;
        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(SpawnEnemy());
        }

    }

    IEnumerator SpawnEnemy()
    {
        for(int i = 0; i <= Random.Range(2, 4); i++)
        {
            if (maxSpawn <= i)
            {
                Instantiate(enemyObject, parentPosition, Quaternion.identity);
                maxSpawn++;
                yield return new WaitForSeconds(2);
            }

            else
            {
                break;
            }
        }

        Destroy(gameObject);
    }
}
