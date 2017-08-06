using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	Transform player;
	public Transform myTransform;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (player);
		transform.Translate(Vector3.forward*5*Time.deltaTime);
	}
}
