using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherBehavior : MonoBehaviour {
	public Vector3 startPosition = new Vector3(0, 0, 0);
	public float timeToReach = 5;
	private float _distance = 2;
	private Vector3 _endPosition;
	private bool _retracting = false;

	void Start() {
		_endPosition = new Vector3(startPosition.x, startPosition.y, startPosition.z - _distance);
	}

	void Update() {
		if (_retracting) {
			transform.position = Vector3.MoveTowards(transform.position,
											  startPosition, (_distance/timeToReach) * Time.deltaTime);
		}
		else {
			transform.position = Vector3.MoveTowards(transform.position,
													 _endPosition, (_distance/timeToReach) * Time.deltaTime);
		}
		
		if (transform.position.z == startPosition.z) {
			_retracting = false;
		}
		else if (transform.position.z == _endPosition.z) {
			_retracting = true;
		}
	}
}