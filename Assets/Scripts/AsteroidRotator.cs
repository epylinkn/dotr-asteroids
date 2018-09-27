using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotator : MonoBehaviour {

  public float tumble;

  private Rigidbody rb;

  private void Start()
  {
    rb = gameObject.GetComponent<Rigidbody>();
    rb.angularVelocity = Random.insideUnitSphere * tumble;
  }
}
