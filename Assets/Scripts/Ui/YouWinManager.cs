using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinManager : MonoBehaviour
{

  public void YouWinManagerUi()
  {

    this.gameObject.SetActive(true);
    Debug.Log("observador " + this.name);

  }


}

