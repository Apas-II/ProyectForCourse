using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveauto2 : moveauto
{




  void Start()
  {
    transform.localScale = transform.localScale * 2;
  }

  // Update is called once per frame
  void Update()
  {
    move();

  }


}
