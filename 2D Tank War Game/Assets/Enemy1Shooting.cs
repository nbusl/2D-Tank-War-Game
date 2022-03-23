using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Shooting : MonoBehaviour
{

    public Transform aim1;
    public GameObject bulletPrefab;
    public float timeBetweenFires = 2.7f;
    public int bulletNumber = 1;

    AudioSource shootSound;

    void Start()
    {
        InvokeRepeating("Shoot", 3.6f, timeBetweenFires);
        shootSound = GetComponent<AudioSource>(); 
    }

    void Shoot()
    {
        shootSound.Play();
        StartCoroutine(ShootCorutine());
    }

    IEnumerator ShootCorutine()
    {
        int i = 0;
        while (i < bulletNumber)
        {
            GameObject enemyBullet1 = Instantiate(bulletPrefab, aim1);
            Rigidbody2D rb = enemyBullet1.GetComponent<Rigidbody2D>();
            
            enemyBullet1.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(7f, 7f), Random.Range(7f, -7f));

            Destroy(enemyBullet1, 2f);
            yield return new WaitForSeconds(timeBetweenFires);
            i++;
        }
    }
}




   
