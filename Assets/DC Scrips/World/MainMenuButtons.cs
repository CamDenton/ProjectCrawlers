using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour {
    public AudioSource uiSound;
    public Canvas menuTwo;
	// Use this for initialization
	void Start () {
        menuTwo.enabled = false;
	}
	
	public void StartGame()
    {
        menuTwo.enabled = true;
        uiSound.Play();

    }
}
