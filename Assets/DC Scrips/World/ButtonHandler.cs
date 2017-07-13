using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonHandler : MonoBehaviour {

    public Canvas buttonsCanvas;
    public Transform playerOne;
    public Transform playerTwo;
    Vector3 playerOneSpawn;
    Vector3 playerTwoSpawn;
    public GameObject playerOneObj;
    public GameObject playerTwoObj;
    public GameObject singlePlayerObj;
    public Camera menuCamera;

    public void Awake()
    {
        playerOneSpawn = playerOne.position;
        playerTwoSpawn = playerTwo.position;
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
}
