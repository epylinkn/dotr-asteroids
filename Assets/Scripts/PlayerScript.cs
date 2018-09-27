﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary {
  public int xMin, xMax, zMin, zMax;
}

public class PlayerScript : MonoBehaviour {
  public int speed = 10;
  public Boundary boundary;

  private Rigidbody rb;

  public GameObject shot;
  public GameObject shotSpawn;
  public float fireRate;
  private float nextFire;

  private void Start()
  {
    rb = gameObject.GetComponent<Rigidbody>();
    Debug.Log(rb);
  }

  private void Update()
  {
    if (Input.GetButton("Fire1") && Time.time > nextFire) {
      nextFire = Time.time + fireRate;
      Instantiate(shot, shotSpawn.transform.position, shotSpawn.transform.rotation);
      GetComponent<AudioSource>().Play();
    }
  }

  private void FixedUpdate()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    rb.velocity = movement * speed;

    rb.position = new Vector3(
      Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
      0.0f,
      Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
    );
      
  }

}
