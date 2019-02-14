using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private int health;

	void Start () {
        health = Constants.DEFAULT_PLAYER_HEALTH;
	}
	
	void Update () {
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Torpedo"))
        {
            TakeDamage();
            Destroy(collision.gameObject);
        }
    }

    private void TakeDamage()
    {
        health -= 1;
        if (health <= 0)
        {
            //You lose
            Debug.Log("You lose");
        }
    }
}
