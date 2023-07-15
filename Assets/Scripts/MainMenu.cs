using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        FindObjectOfType<AudioManagerScript>().Play("play");
        SceneManager.LoadScene("sec");
       
    }



}