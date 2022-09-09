using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Object Data", menuName = "ObjectData")]

public class ObjectData : ScriptableObject
{
  [SerializeField] public string NameObject;
  [SerializeField] public int Score;





}
