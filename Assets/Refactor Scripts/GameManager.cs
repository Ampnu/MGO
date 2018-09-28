using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//-----This script controls the Game States and UI information-----//

public class GameManager : MonoBehaviour {

    public Text scoreDisplayUI;
    public int score;
    public AudioSource ping;

    void Start ()
    {
        ping = this.GetComponent<AudioSource>();
        score = 0;
	}
	
	void Update ()
    {
        scoreDisplayUI.text = score.ToString();
	}
}
