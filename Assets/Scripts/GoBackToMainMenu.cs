using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMainMenu : MonoBehaviour
{
    public void RetryButton()
    {
        SceneManager.LoadScene("sec");
        FindObjectOfType<AudioManagerScript>().Play("restart");
    }
}
