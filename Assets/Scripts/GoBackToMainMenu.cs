using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMainMenu : MonoBehaviour
{
    public void RetryButton()
    {
        SceneManager.LoadScene("game");
        FindObjectOfType<AudioManagerScript>().Play("restart");
    }
}
