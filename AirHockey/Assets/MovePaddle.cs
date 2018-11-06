using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour
{

  private Vector3 pos;

  // Use this for initialization
  void Start()
  {
    Input.multiTouchEnabled = true;
    pos = new Vector3(this.transform.position.x, this.transform.position.y, 0.5f);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      this.transform.position = Camera.main.WorldToScreenPoint(Input.mousePosition);
      Debug.Log(Input.mousePosition);
    }
  }
}
