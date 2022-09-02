using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciatecar : MonoBehaviour

{

  public GameObject[] Auto;
  void Start()
  {

  }

  void Update()
  {


    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out RaycastHit hitinfo, 40))

    {
      Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 40, Color.blue);


      if (hitinfo.transform.CompareTag("Player"))
      {
        foreach (var i in Auto)
        {
          i.SetActive(true);
        };



        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 40, Color.green);
        Debug.Log(" le pegue");
      }
    }


  }
}