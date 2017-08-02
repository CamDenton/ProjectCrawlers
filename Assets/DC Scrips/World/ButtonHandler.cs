using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonHandler : MonoBehaviour {

    public Canvas buttonsCanvas;
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
    public Camera menuCamera;

    public void Awake()
    {
        playerOneSpawn = playerOne.position;
        playerTwoSpawn = playerTwo.position;
        playerThreeSpawn = playerThree.position;
        playerFourSpawn = playerFour.position;
    }

    public void PlayerOneSelected()
    {
        buttonsCanvas.enabled = false;
        menuCamera.enabled = false;
        Instantiate(singlePlayerObj, playerOneSpawn, Quaternion.identity);
       
    }

    public void PlayerTwoSelected()
    {
        buttonsCanvas.enabled = false;
        menuCamera.enabled = false;
        Instantiate(playerOneObj, playerOneSpawn, Quaternion.identity);
        Instantiate(playerTwoObj, playerTwoSpawn, Quaternion.identity);
         
    }

    public void PlayerThreeSelected()
    {
        buttonsCanvas.enabled = false;
        menuCamera.enabled = false;
        Instantiate(playerThreeObj, playerThreeSpawn, Quaternion.identity);
        Instantiate(playerTwoCornerObj, playerTwoSpawn, Quaternion.identity);
        Instantiate(playerOneCornerObj, playerOneSpawn, Quaternion.identity);
    }

    public void PlayerFourSelected()
    {
        buttonsCanvas.enabled = false;
        menuCamera.enabled = false;
        Instantiate(playerOneCornerObj, playerOneSpawn, Quaternion.identity);
        Instantiate(playerTwoCornerObj, playerTwoSpawn, Quaternion.identity);
        Instantiate(playerThreeCornerObj, playerThreeSpawn, Quaternion.identity);
        Instantiate(playerFourObj, playerFourSpawn, Quaternion.identity);

    }
}
