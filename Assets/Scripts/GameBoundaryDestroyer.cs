using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoundaryDestroyer : MonoBehaviour {

  private void OnTriggerExit(Collider other)
  {
    Destroy(other.gameObject);
  }
}
