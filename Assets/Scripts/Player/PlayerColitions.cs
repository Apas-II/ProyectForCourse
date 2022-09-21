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






  public Dictionary<string, int> InventoryDictionary = new Dictionary<string, int>() // esto se va
  {
    {"Banana", 0},
    {"Manzana", 0}


  };



  /// COLISIONESSSS ///
  private void OnCollisionEnter(Collision other)
  {

    if (other.collider.CompareTag("Coletables"))
    {
      ;
      Destroy(other.gameObject);
      GameManager.Instance.Score++;
      GameManager.Instance.inventory.Add(other.gameObject.name); // eso se va


      if (InventoryDictionary.ContainsKey(other.gameObject.name)) //esto se vaa
      {
        Debug.Log(InventoryDictionary[other.gameObject.name]); //esto se va
        InventoryDictionary[other.gameObject.name] += 1; // esto se vaa

        // aca profe. no puedo hacer que se sumen los Values de las Key. 

      };


      Debug.Log(InventoryDictionary["Manzana"]); // esto se va 
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
      Debug.Log("emisor " + this.name); //esto se va


      if (GameManager.Instance.Lives == 0)
      {
        onDead.Invoke();
        Debug.Log("emisor " + this.name); //esto se va
      }

    }



  }






}


//condicion de victoria en un script atached a el finishline object, que tiene un raycast para advertir la victoria ( o un collider)


// otra condicion de derrota con el timmer == 0;