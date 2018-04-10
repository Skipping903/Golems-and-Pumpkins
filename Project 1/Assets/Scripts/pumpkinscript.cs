using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumpkinscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 2f;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Golem")
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
        }
    }

    // Update is called once per frame
    void Update () {
        if (this.transform.position.y < -5f)
            Destroy(this.gameObject);
	}
}
