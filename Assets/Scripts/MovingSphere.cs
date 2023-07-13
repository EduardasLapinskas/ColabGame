using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    private const System.Double V = 0.02;
    public float z = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation =  Quaternion.Euler(0,0,z);
       z = (float)(z +0.2);
    }
    
}
