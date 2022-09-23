using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class PlayerColitions : MonoBehaviour

{

  [SerializeField] private UnityEvent onHit;
  [SerializeField] private UnityEvent onDead;

  void Start()
  {



  }





  /// COLISIONESSSS ///
  private void OnCollisionEnter(Collision other)
  {

    if (other.collider.CompareTag("Coletables"))
    {
      ;
      Destroy(other.gameObject);
      GameManager.Instance.Score++;



    }

    if (other.collider.CompareTag("Lives"))
    {
      Destroy(other.gameObject);
      GameManager.Instance.Lives++;


    }



    // condiciones de hit y de derrota
    if (other.collider.CompareTag("Obstacles") || other.collider.CompareTag("Enemys") || other.collider.CompareTag("PlanetoFall"))
    {

      onHit.Invoke();
      GameManager.Instance.Lives--;



      if (GameManager.Instance.Lives == 0)
      {
        onDead.Invoke();

      }

    }



  }






}


//condicion de victoria en un script atached a el finishline object, que tiene un raycast para advertir la victoria ( o un collider)


// otra condicion de derrota con el timmer == 0;