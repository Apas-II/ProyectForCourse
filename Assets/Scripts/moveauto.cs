using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveauto : MonoBehaviour
{


  [SerializeField]
  public Vector3 direction;
  [SerializeField]
  public int speed = 25;

  void Start()
  {

  }


  void Update()
  {
    move();
  }


  protected void move()
  {
    transform.position = transform.position + direction * Time.deltaTime * speed;
  }




}
