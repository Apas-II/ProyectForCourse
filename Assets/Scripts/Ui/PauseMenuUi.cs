using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuUi : MonoBehaviour
{
  public static bool GameIsPause = false;
  public GameObject PauseMenuUiGameoBj;

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Return))
    {





      if (GameIsPause)
      {
        Resume();
      }
      else
      {
        Pause();
      }
    }
  }

  void Pause()
  {
    PauseMenuUiGameoBj.SetActive(true);
    Time.timeScale = 0f;
    GameIsPause = true;

  }

  public void Resume()
  {
    PauseMenuUiGameoBj.SetActive(false);
    Time.timeScale = 1f;
    GameIsPause = false;

  }

  public void BacktoMainMenu()
  {

    SceneManager.LoadScene("LandingMenu");
    Time.timeScale = 1f;
    GameIsPause = false;

  }

}
