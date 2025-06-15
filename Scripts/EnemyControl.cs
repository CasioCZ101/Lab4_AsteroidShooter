using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    private Rigidbody enemyRB;
    public float enemySpeed = 1.0f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 attackForce = player.transform.position - transform.position;
        enemyRB.AddForce(attackForce * enemySpeed);
    }
}
