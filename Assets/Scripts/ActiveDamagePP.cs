using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDamagePP : MonoBehaviour
{

  public void activeDamagePP()
  {
    this.gameObject.SetActive(true);
    StartCoroutine(CountdownDamage());
  }


  IEnumerator CountdownDamage()
  {


    yield return new WaitForSeconds(0.1f);
    this.gameObject.SetActive(false);



  }

}
