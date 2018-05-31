using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour {

    public bool powerStatus = false;

    private GameManager points;
    private PlayerController playerPickUp;
    private ParticleSystem powerUp;
    private int powerUpTime = 10;

    void OnTriggerEnter(Collider other)
    {
        //When player hit a relic
        if (other.tag == "Player" && this.tag == "Relic") 
        {
            if(powerStatus == false)
            {
                points.score = points.score + 10;
                powerUp.Play(true);
                StartCoroutine(PowerUp());
            }  
        }
        //When a player hits a orb
        else
        {
            playerPickUp.ping.Play();
            ++points.score;
            gameObject.SetActive(false);           
        }
    }

    private void Start()
    {
        points = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerPickUp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        powerUp = GameObject.FindGameObjectWithTag("PowerUp").GetComponent<ParticleSystem>();
        powerUp.Stop(true);       
    }

    IEnumerator PowerUp()
    {
       
        powerUp.Play(true);
        powerStatus = true;
        print("POWER UP");
        yield return new WaitForSeconds(powerUpTime);
        powerStatus = false;
        print("POWER DOWN");
        powerUp.Stop(true);
        gameObject.SetActive(false);


    }
}
