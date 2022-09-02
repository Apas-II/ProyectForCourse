using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  private static GameManager instance;



  public static GameManager Instance


  {
    get
    {
      if (instance == null)
      {
        Debug.LogError("GameManager is NUll!");
      }
      return instance;
    }
  }

  public int Score = 0;

  public List<string> inventory = new List<string>();




  private void Awake()
  {
    instance = this;
  }


}

