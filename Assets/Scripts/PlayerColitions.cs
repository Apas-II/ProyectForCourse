using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColitions : MonoBehaviour
{
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



  }






}
