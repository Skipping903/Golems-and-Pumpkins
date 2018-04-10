using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golemmovement : MonoBehaviour {

    private Rigidbody mybody;
    private float moveForce = 10f;

	// Use this for initialization
	void Awake ()
    {
        this.mybody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        this.mybody.velocity = new Vector3(-h * this.moveForce, 0f, 0f);
	}
}
