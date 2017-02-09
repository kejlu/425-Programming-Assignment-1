using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachedGoal : MonoBehaviour {

	void Start () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Goal")) {
			Physics.gravity = new Vector3 (0, 10f, 0);
		}
	}

}
