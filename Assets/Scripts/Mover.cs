using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
  public float speed = 1.0f;
  private Rigidbody rb;

  private void Start()
  {
    rb = gameObject.GetComponent<Rigidbody>();
    rb.velocity = transform.forward * speed;

  }
}
