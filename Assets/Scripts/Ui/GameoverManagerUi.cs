using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverManagerUi : MonoBehaviour
{
  public void GameOverManager()
  {

    this.gameObject.SetActive(true);
    Debug.Log("observador " + this.name);
  }


}
