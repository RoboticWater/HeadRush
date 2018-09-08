﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVehicleController : VehicleDriveController {

	private float speed = 9f;
	private float correction;
	private float startingHealth = 15f;
	public GameObject player;
	// Use this for initialization
	void Start () {
		base.Health = startingHealth;
		base.Rb = gameObject.GetComponent<Rigidbody> ();

	}

	// Update is called once per frame
	new void Update () {
		base.Update();
		MoveZDir (speed, 1);
	}
}