﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    private Vector3 offset;
    public GameObject player;

	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	void Update () {
        Follow();
	}

    void Follow()
    {
        transform.position = player.transform.position + offset;
    }
}
