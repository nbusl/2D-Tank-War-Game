using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed = 0.85f;
    public bool MoveDown;
    
     void Update()
    {

       if (MoveDown)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0); 
        }
        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bound"))
        {
            if (MoveDown)
            {
                MoveDown = false;
            }
            else
            {
                MoveDown = true;
            }
        }
    }
}
