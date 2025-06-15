using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserBlast : MonoBehaviour
{
    private float speed = 20.0f;

    public GameObject laserBlastPrefab;
       
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    //Se o asteroide bater na nave, criar explosão, destroi o asteroid e tira uma vida da nave;
    //Se o laser bater no asteroide explode e é destruido... o laser tbm é destruído;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("AsteroidDumb"))
        {
            Debug.Log("Hit Asteroid_laser_blast");
            explosionParticle.Play();
            Destroy(laserBlastPrefab.gameObject);
            Destroy(collision.gameObject);         

        }
       
    }
}
