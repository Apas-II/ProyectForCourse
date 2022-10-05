using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameoverManagerUi : MonoBehaviour
{
  public void GameOverManager()
  {

    this.gameObject.SetActive(true);
    Time.timeScale = 0f;

  }

  public void BacktoMainMenu()
  {
    SceneManager.LoadScene("LandingMenu");
    Time.timeScale = 1f;
  }



}

