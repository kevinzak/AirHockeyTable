using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPaddle : MonoBehaviour
{

  public GameObject clone;

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
    {
      Vector2 fingerPos = Input.GetTouch(0).position;
      // fingerPos.z = 5;
      Debug.Log(fingerPos);
      // Vector3 objPos = Camera.main.ScreenToWorldPoint(fingerPos);
      // clone = Instantiate(trail, objPos, Quaternion.identity) as GameObject;

    }
  }
}
