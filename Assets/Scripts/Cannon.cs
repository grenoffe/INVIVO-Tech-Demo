﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform FireLocation;
    public Transform Planet;

    public GameObject CannonballPrefab;

    void Update() {
        if (Input.GetMouseButtonUp(0)) {
            FireCannonball();
        }    
    }
    public void FireCannonball() {
        var cannonball = Instantiate(CannonballPrefab, FireLocation.position, FireLocation.rotation);
        Cannonball controller = cannonball.GetComponent<Cannonball>();
        controller.GravitySource = Planet;

    } 
}
