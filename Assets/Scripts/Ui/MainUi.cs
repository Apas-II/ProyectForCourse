using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUi : MonoBehaviour
{


  public void RaceScene() => SceneManager.LoadScene("RaceScene");

  public void ForestScene() => SceneManager.LoadScene("ForestScene");

  public void SpaceScene() => SceneManager.LoadScene("SpaceScene");


  public void ExitMainUi() => Application.Quit();

}
