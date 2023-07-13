using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    [SerializeField] float radius;
    [SerializeField] GameObject point;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPoint();
    }

    float counter = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnPoint();
        }

    }


    public void SpawnPoint()
    {
        Vector3 rotation = Quaternion.Euler(0f, 0f, Random.Range(0, 360)) * new Vector2(radius, radius);
        Instantiate(point, rotation, Quaternion.identity);
    }

}
