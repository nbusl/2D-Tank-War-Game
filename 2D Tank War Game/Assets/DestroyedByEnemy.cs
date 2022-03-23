using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedByEnemy : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("EnemyBullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
