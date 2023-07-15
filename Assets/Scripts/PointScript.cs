using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    //[SerializeField] GameObject SpawnScriptObject;
    GameObject _gameManager;
    bool inCircle;
    bool isBehindCircle;
    Collider2D _other;
    public int skaicius;

    void Start()
    {
        _gameManager = GameObject.FindGameObjectsWithTag("GameManager")[0];
        print(_gameManager.name);
    }

    void Update()
    {
        Logic(_other);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        inCircle = true;
        //
        _other = other;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        inCircle = false;
        isBehindCircle = true; // patikrina ar uz apskritimo
                               // (problema buvo kad kai sunaikinome apskritima uzkaite kaip game over, nes jau nebe rate
                               // del to paspaudus matydamove gameover)
    }

    void Logic(Collider2D other)
    {
        if (isBehindCircle)
        {
            if (_gameManager != null)
                _gameManager.GetComponent<GameManager>().gameOver();

            other.gameObject.SetActive(false); // isjungia square player
            return; // nebevykdo kas uz jo
        }

        if (Input.GetMouseButtonDown(0) && inCircle)
        {
            FindObjectOfType<AudioManagerScript>().Play("appear-online");
            skaicius = 1;

            _gameManager.GetComponent<GameManager>().addScore(skaicius);

            //SpawnScriptObject.GetComponent<spawner>().SpawnPoint();
            other.GetComponentInParent<MovingSphere>().ChangeDir();
            isBehindCircle = false;

            Destroy(gameObject);

        }


        //cia patikrink ar paspaude ir ar yra rate jei ne 
        //gamemanager.gameOver();

        //poto sukurk button pridek ant jo game manager objekta ir skripte iskviesk gamemanager.gameOver();
    }


}
