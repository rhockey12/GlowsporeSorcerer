using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skull_animate : MonoBehaviour
{
      void Update()
    {
        transform.position = new Vector3(0, Mathf.Sin(Time.time), 0);
    }
}
