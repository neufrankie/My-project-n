using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
  void OnCollisionEnter(Collision collision)
 {
    if(collision.gameObject.CompareTag("Obstacle"))
    {
        GameOver();
    }
 }
 void GameOver()
 {
    SceneManager.LoadScene("GameOverScene");
 }
}
