using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinManager : MonoBehaviour
{

  public GameObject victoryPannel;
  public void YouWinManagerUi()
  {

    victoryPannel.SetActive(true);


  }


  public void BacktoMainMenu()
  {
    SceneManager.LoadScene("LandingMenu");
  }
}

