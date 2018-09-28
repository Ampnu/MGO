using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//-----This script controls the item collection mechanic-----//

public class ItemCollection : MonoBehaviour {

    private GameManager gm;
 
    private void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();        
    }

    void OnTriggerEnter(Collider other)
    {
        CollectOrb(other);
        CollectRelic(other);
    }

    //--------------------------------------------------------------------------CORE FUNCTIONS----------------------------------------------------------------------------------------------//

    void CollectOrb(Collider val)
    {
        if (val.tag == "Player" && this.gameObject.name.Contains("Orb"))
        {
            gm.ping.Play();
            ++gm.score;
            Destroy(this.gameObject);
        }
    }

    void CollectRelic(Collider val)
    {      
        if (val.tag == "Player" && this.gameObject.name.Contains("Relic"))
        {
            print("This is a relic");
            //gm.ping.Play();
            gm.score = gm.score + 20;
            Destroy(this.gameObject);
        }
    }
}
