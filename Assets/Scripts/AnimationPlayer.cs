using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
  public GameObject PLayer;
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.UpArrow))

    {
      PLayer.GetComponent<Animator>().Play("Jump");
    }
  }
}
