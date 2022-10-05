using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDamagePP : MonoBehaviour
{
  public GameObject damageLayer;
  public void activeDamagePP()
  {
    damageLayer.SetActive(true);
    StartCoroutine(CountdownDamage());
  }


  IEnumerator CountdownDamage()
  {


    yield return new WaitForSeconds(0.1f);
    damageLayer.SetActive(false);



  }

}
