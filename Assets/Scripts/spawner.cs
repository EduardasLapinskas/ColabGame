using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    [SerializeField] float radius;
    [SerializeField] GameObject point;
    [SerializeField] Transform playerTransform;

    [SerializeField] GameObject pointInScene;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPoint();
    }

    float counter = 0;
    // Update is called once per frame
    void Update()
    {

        if (pointInScene == null)
        {
            SpawnPoint();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnPoint();
        }


    }


    public void SpawnPoint()
    {
        int randRotation = Random.Range(0, 360);



        // Vector3 rotationPos = Quaternion.Euler(0f, 0f, randRotation) * new Vector2(radius, radius);
        // float distance = Vector2.Distance(playerTransform.position, rotationPos);

        Vector2 pos = new Vector2(Mathf.Sin(Mathf.Deg2Rad * randRotation), Mathf.Cos(Mathf.Deg2Rad * randRotation)) * radius;
        float distance = Vector2.Distance(playerTransform.position, pos);
        if (distance < 2f)
            pos = new Vector2(Mathf.Sin(Mathf.Deg2Rad * randRotation - 30), Mathf.Cos(Mathf.Deg2Rad * randRotation - 30)) * radius;
        // if (distance < 2f)
        //     rotationPos = Quaternion.Euler(0f, 0f, randRotation + 180) * new Vector2(radius, radius);

        pointInScene = Instantiate(point, pos, Quaternion.identity);
    }

}
