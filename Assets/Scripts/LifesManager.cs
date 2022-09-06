using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifesManager : MonoBehaviour
{
  [SerializeField]
  private int HudScore;
  Text txt;
  private string HudlifeText;

  private void Start()
  {
    txt = GetComponent<Text>();

  }

  private void Update()
  {

    HudScore = GameManager.Instance.Lives;
    txt.text = HudScore.ToString();



  }




}
