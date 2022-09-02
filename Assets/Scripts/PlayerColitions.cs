using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColitions : MonoBehaviour
{
  private void OnCollisionEnter(Collision other)
  {
    if (other.collider.CompareTag("Coletables"))
    {
      Debug.Log("le pegue");
      Destroy(other.gameObject);
      GameManager.Instance.Score++;
      GameManager.Instance.inventory.Add(other.gameObject.name);
    }
  }
}
