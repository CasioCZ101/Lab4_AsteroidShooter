using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private float speed = 1000.0f;
    public GameObject laserBlastPrefab;
    private float limiteLateral = 67;
    private float limiteFrontal = 67;
    public ParticleSystem explosionParticle;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();         
    }

    // Update is called once per frame
    void Update()
    {
        float forwardForce = Input.GetAxis("Vertical");
        float sideMoves = Input.GetAxis("Horizontal");

        //Códigos para movimentação lateral
        playerRB.AddForce(playerRB.transform.right * sideMoves * speed);
        if (transform.position.x < -limiteLateral)
        {
            transform.position = new Vector3((-limiteLateral), transform.position.y, transform.position.z);
            //playerRB.AddForce(playerRB.transform.right * sideMoves * speed);
        }    
      
        if (transform.position.x > limiteLateral)
        {
            transform.position = new Vector3((limiteLateral), transform.position.y, transform.position.z);
            //playerRB.AddForce(playerRB.transform.forward * forwardForce * speed);
        }

        //Códigos de movimentação para frente e para trás
        playerRB.AddForce(playerRB.transform.forward * forwardForce * speed);

        if (transform.position.z < -limiteFrontal)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, (-limiteFrontal));
            //playerRB.AddForce(playerRB.transform.right * sideMoves * speed);
        }

        if (transform.position.z > limiteFrontal)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, (limiteLateral));
            //playerRB.AddForce(playerRB.transform.forward * forwardForce * speed);
        }


        //Aciona o míssil da nave
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            laserBlastPrefab.transform.position = new Vector3(0,0,10.0f);
            //Instantiate(laserBlastPrefab, transform.position, laserBlastPrefab.transform.rotation);
            Instantiate(laserBlastPrefab, (transform.position + laserBlastPrefab.transform.position), laserBlastPrefab.transform.rotation);


        }

    }

    //Se o asteroide bater na nave, criar explosão, destroi o asteroid e tira uma vida da nave;
    private void OnCollisionEnter(Collision COLISION)
    {
        if (COLISION.gameObject.CompareTag("AsteroidDumb"))
        {            
            Debug.Log("Asteroid Hit ship_player_control");
            Destroy(COLISION.gameObject);
            explosionParticle.Play();
        }      
    }    
}
