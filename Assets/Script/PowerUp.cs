using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public bool powerStatus = false;

    private ParticleSystem powerUp;
    private GameManager points;
    private int powerUpTime = 15;

    private void Start()
    {
        points = GameObject.Find("Game Manager").GetComponent<GameManager>();
        powerUp = GameObject.Find("PowerUpVFX").GetComponent<ParticleSystem>();
        powerUp.Stop(true);
    }

    void OnTriggerEnter(Collider other)
    {
        //When player hit a relic
        if (other.tag == "Target" && this.tag == "Relic")
        {
            if (!powerStatus)
            {
                StartCoroutine(RelicPowerUp());
                points.score = points.score + 10;
            }   
        }
    }
 
    IEnumerator RelicPowerUp()
    {
        powerStatus = true;
        powerUp.Play(true);
        yield return new WaitForSeconds(powerUpTime);
        powerUp.Stop(true);
        gameObject.SetActive(false);
        powerStatus = false;
    }
}
