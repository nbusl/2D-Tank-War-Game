using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInsideTheBoundaries : MonoBehaviour
{
     void Update()
    {
       transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10.61f, 21.915f),
       Mathf.Clamp(transform.position.y, -5.432f, 17.395f), transform.position.z);
    }
}
