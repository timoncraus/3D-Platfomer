using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptaboutE : MonoBehaviour {

    bool active = true;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.E))
        {
            active = !(active);
        }

        gameObject.SetActive(active);
    }
}
