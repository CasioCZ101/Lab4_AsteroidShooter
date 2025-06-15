using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsFollow : MonoBehaviour
{
    private Rigidbody asteroidFollowRB;
    public float asteroidSpeed = 1.0f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        asteroidFollowRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 attackForce = player.transform.position - transform.position;
        asteroidFollowRB.AddForce(attackForce * asteroidSpeed);
    }
}

