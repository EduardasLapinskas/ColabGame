
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    private float V = 1f;
    public float z = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        
        gameObject.transform.rotation = Quaternion.Euler(0, 0, z);
        z = (float)(z + V);



    }

    public void ChangeDir()
    {
        V *= -1;
    }

}
