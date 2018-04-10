﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
    public Transform[] spawnPoints;
    public GameObject pumpkin;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning() {
        yield return new WaitForSeconds (Random.Range(1f, 3.5f));
        Instantiate (pumpkin, spawnPoints[Random.Range(0, spawnPoints.Length)].position,
            Quaternion.identity);
        StartCoroutine (StartSpawning());
	}

}