
using UnityEngine;
using UnityEngine.Events;



public class VictoryTrigger : MonoBehaviour
{

  [SerializeField] private UnityEvent myTriggerVictory;

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {

      myTriggerVictory.Invoke();
      Debug.Log("emisor " + this.name); //esto se va

    }



  }



}


