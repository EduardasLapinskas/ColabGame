using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{

    [SerializeField] GameObject SpawnScriptObject;
    bool inCircle;
    Collider2D _other;

    void Update()
    {
        Logic(_other);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        inCircle = true;
        _other = other;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        inCircle = false;
    }

    void Logic(Collider2D other)
    {
        if (Input.GetMouseButtonDown(0) && inCircle)
        {
            SpawnScriptObject.GetComponent<spawner>().SpawnPoint();
            other.GetComponentInParent<MovingSphere>().ChangeDir();
            Destroy(gameObject);
        }
    }
}
