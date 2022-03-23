using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBullet : MonoBehaviour
{
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect) as GameObject;
        effect.transform.position = transform.position;
        Destroy(effect, 1f);
        Destroy(gameObject);

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
