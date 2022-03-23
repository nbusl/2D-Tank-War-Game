using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    public int enemyCount1 = 2;
   
   

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemyCount1--;

            if (collision.gameObject.CompareTag("Enemy1"))
            {
                enemyCount1--;
                Debug.Log("1 Enemy Left!");
            }
        }

        if (enemyCount1 <= 0)
        {
            SceneManager.LoadScene("GameOver1");
        }

    }
          
}
         
        



