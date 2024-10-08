using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptaboutL : MonoBehaviour {

    bool active = true;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.L))
        {
            active = !(active);
        }

        gameObject.SetActive(active);
    }
}
