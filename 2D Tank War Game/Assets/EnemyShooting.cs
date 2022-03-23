using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform aim;
    public GameObject bulletPrefab;
    public float timeBetweenSeries = 3f;
    public float timeBetweenBullets = 0.7f;
    public int bulletNumber = 2;
    AudioSource shootSound;

    void Start()
    {
        InvokeRepeating("Shoot", 6f, timeBetweenSeries);
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
        while(i < bulletNumber)
        {
            GameObject enemyBullet = Instantiate(bulletPrefab, aim);
            enemyBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-9f, -6f), Random.Range(-5f, 7f));
            Destroy(enemyBullet, 2f);
            yield return new WaitForSeconds(timeBetweenBullets);
            i++;
        } 
    }
}
