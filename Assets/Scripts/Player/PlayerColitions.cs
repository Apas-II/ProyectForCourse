using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerColitions : MonoBehaviour

{


  public event Action onDead;


  public Dictionary<string, int> InventoryDictionary = new Dictionary<string, int>()
  {
    {"Banana", 0},
    {"Manzana", 0}


  };




  private void OnCollisionEnter(Collision other)
  {

    if (other.collider.CompareTag("Coletables"))
    {
      ;
      Destroy(other.gameObject);
      GameManager.Instance.Score++;
      GameManager.Instance.inventory.Add(other.gameObject.name);


      if (InventoryDictionary.ContainsKey(other.gameObject.name))
      {
        Debug.Log(InventoryDictionary[other.gameObject.name]);
        InventoryDictionary[other.gameObject.name] += 1;

        // aca profe. no puedo hacer que se sumen los Values de las Key. 

      };


      Debug.Log(InventoryDictionary["Manzana"]);
    }

    if (other.collider.CompareTag("Lives"))
    {
      Destroy(other.gameObject);
      GameManager.Instance.Lives++;


    }

    if (other.collider.CompareTag("Obstacles") || other.collider.CompareTag("Enemys") || other.collider.CompareTag("PlanetoFall"))
    {


      GameManager.Instance.Lives--;


      if (GameManager.Instance.Lives == 0)
      {
        //condicion de  derrota
      }

    }



  }






}


//condicion de victoria en un script atached a el finishline object, que tiene un raycast para advertir la victoria ( o un collider)


// otra condicion de derrota con el timmer == 0;