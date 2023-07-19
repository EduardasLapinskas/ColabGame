
using System.Threading;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    private float paddleAngle = 0;
    [SerializeField] GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //gameObject.transform.rotation = Quaternion.Euler(0, 0, z);
        //z = (float)(z + V);



    }
    void FixedUpdate()
    {
        gameObject.transform.rotation = Quaternion.Euler(0, 0, paddleAngle);
        paddleAngle = (float)(paddleAngle + speed);

    }
    public void ChangeDir()
    {
        speed *= -1;
    }

}
