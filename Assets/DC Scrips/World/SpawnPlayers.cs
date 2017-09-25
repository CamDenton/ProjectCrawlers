using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour {

    public GameObject startManager;
    ManagePlayers playerManager;
    public Transform playerOne;
    public Transform playerTwo;
    public Transform playerThree;
    public Transform playerFour;
    Vector3 playerOneSpawn;
    Vector3 playerTwoSpawn;
    Vector3 playerThreeSpawn;
    Vector3 playerFourSpawn;
    public GameObject playerOneObj;
    public GameObject playerOneCornerObj;
    public GameObject playerTwoObj;
    public GameObject playerTwoCornerObj;
    public GameObject playerThreeObj;
    public GameObject playerThreeCornerObj;
    public GameObject playerFourObj;
    public GameObject singlePlayerObj;


    public void Awake()
    {
        playerOneSpawn = playerOne.position;
        playerTwoSpawn = playerTwo.position;
        playerThreeSpawn = playerThree.position;
        playerFourSpawn = playerFour.position;
        startManager = GameObject.Find("StartManager");
        playerManager = startManager.GetComponent<ManagePlayers>();

        if (playerManager.singleSelected == true)
        {
            PlayerOneSelected();
        }

        else if(playerManager.twoSelected == true)
        {
            PlayerTwoSelected();
        }
    }

    public void PlayerOneSelected()
    {

        Instantiate(singlePlayerObj, playerOneSpawn, Quaternion.identity);

    }

    public void PlayerTwoSelected()
    {

        Instantiate(playerOneObj, playerOneSpawn, Quaternion.identity);
        Instantiate(playerTwoObj, playerTwoSpawn, Quaternion.identity);

    }

    public void PlayerThreeSelected()
    {

        Instantiate(playerThreeObj, playerThreeSpawn, Quaternion.identity);
        Instantiate(playerTwoCornerObj, playerTwoSpawn, Quaternion.identity);
        Instantiate(playerOneCornerObj, playerOneSpawn, Quaternion.identity);
    }

    public void PlayerFourSelected()
    {

        Instantiate(playerOneCornerObj, playerOneSpawn, Quaternion.identity);
        Instantiate(playerTwoCornerObj, playerTwoSpawn, Quaternion.identity);
        Instantiate(playerThreeCornerObj, playerThreeSpawn, Quaternion.identity);
        Instantiate(playerFourObj, playerFourSpawn, Quaternion.identity);

    }
}
