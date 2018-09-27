using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
  public GameObject hazard;
  public Vector3 spawnValues;
  public int hazardCount = 3;

  public float waveWait = 0.0f;
  public float spawnWait = 1.0f;
  public float startWait = 1.0f;

  public Text scoreText;
  private int score = 0;

  private void Start()
  {
    UpdateScore();
    StartCoroutine(SpawnWaves());
  }

  IEnumerator SpawnWaves() {

    yield return new WaitForSeconds(startWait);

    while (true) {
      for (int i = 0; i < hazardCount; i++)
      {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        Instantiate(hazard, spawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(spawnWait);
      }

      yield return new WaitForSeconds(waveWait);
    }

  }

  public void AddScore(int newScoreValue)
  {
    score += newScoreValue;
    UpdateScore();
  }

  public void UpdateScore() {
    scoreText.text = "Score: " + score;
  }

}
