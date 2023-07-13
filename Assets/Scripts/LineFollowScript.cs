using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineFollowScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        print("HIT");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print("HIT Trigger");
    }
}
