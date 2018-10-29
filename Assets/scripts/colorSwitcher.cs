using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSwitcher : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.blue;
        Destroy(gameObject, 2.0f);
    }
}
