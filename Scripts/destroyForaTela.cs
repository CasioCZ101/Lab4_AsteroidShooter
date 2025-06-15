using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyForaTela : MonoBehaviour
{
    private float limiteTela = -80.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < limiteTela)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > -limiteTela)
        {
            Destroy(gameObject);
        }
    }
}
