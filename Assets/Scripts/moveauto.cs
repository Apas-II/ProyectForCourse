using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveauto : MonoBehaviour
{


  [SerializeField]
  public Vector3 direction;

  void Start()
  {

  }


  void Update()
  {
    transform.position = transform.position + direction * Time.deltaTime * 25;
  }
}
