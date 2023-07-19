using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public GameObject gameoverScreen;

    [SerializeField] TextMeshProUGUI highScoreText;

    [SerializeField] GameObject Lock;
    [SerializeField] GameObject LockUI;


    public void addScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
        CheckHighscore();
    }

    void CheckHighscore()
    {
        if (score > PlayerPrefs.GetInt("Highscore", 0))
            PlayerPrefs.SetInt("Highscore", score);
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    public void gameOver()
    {
        UpdateHighScoreText();
        gameoverScreen.SetActive(true);

        LockAnimation();
    }


    //Pressed button script
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    void LockAnimation()
    {

        if (Lock.TryGetComponent<Animator>(out Animator lockAnime) && LockUI.TryGetComponent<Animator>(out Animator LockUIAnime))
        {
            lockAnime.SetTrigger("FailUnlock");
            LockUIAnime.SetTrigger("FailUnlock");
        }

    }
}
