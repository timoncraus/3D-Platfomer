using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour {
	
	public float looseVerticalPosition;

	private Vector3 _startPosition;

	// Use this for initialization
	void Start () {
		_startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= looseVerticalPosition) {
			transform.position = 	_startPosition;	
		}
	}
}
