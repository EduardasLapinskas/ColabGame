using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{

    [SerializeField] GameObject SpawnScriptObject;


    void OnTriggerStay2D(Collider2D other)
    {

        if (Input.GetMouseButtonDown(0))
        {
            SpawnScriptObject.GetComponent<spawner>().SpawnPoint();
            Destroy(gameObject);
        }
    }
}
