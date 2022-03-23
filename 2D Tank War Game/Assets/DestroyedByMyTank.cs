using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedByMyTank : MonoBehaviour
{
    //public int health = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            /*health--;
            if(health <= 0)
            {
                KillObject();
            }*/
        }
    }
   /* void KillObject()
    {
        Destroy(gameObject);
    }*/

   

    /* public int health = 15;

     public GameObject deathEffect;

     public void TakeDamage(int damage)
     {
         health = health - damage;
         if(health <= 0)
         {
             Die();
         }
     }
     void Die()
     {
         Instantiate(deathEffect, transform.position, Quaternion.identity);
         Destroy(gameObject);
     }*/

}
