using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torpedo : MonoBehaviour {

    private float speed;
    Collider capsuleCollider;

	// Use this for initialization
	void Start () {
        capsuleCollider = gameObject.GetComponent<CapsuleCollider>();
        speed = Constants.STARTING_TORP_SPEED;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up * speed * Time.deltaTime;
	}

    private void OnDestroy()
    {
        //Play an animation or something
    }
}
