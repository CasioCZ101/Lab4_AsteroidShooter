using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AsteroidsDumb : MonoBehaviour
{
    public float asteroidSpeed = 20.0f;
   
    // Start is called before the first frame update
    /*
    void Start()
    {
       
    }
    */
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * (Vector3.forward) * Time.deltaTime * asteroidSpeed );
    }
}

