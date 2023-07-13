using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        print("HIT!!");
    }
}
