using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : Entity {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DestroyGO();
    }
    void HitByRay() {
        health -= 1;

        Debug.Log("I am a block and was hit, health: "+health);
    }
}
