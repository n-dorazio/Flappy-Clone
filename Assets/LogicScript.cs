using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;

    public TextMeshProUGUI HighScore;

    private void Start()
    {
        updateHighScore();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd){
        playerScore= playerScore+ scoreToAdd;
        scoreText.text=playerScore.ToString();
        dingSFX.Play();
        checkHighScore();
    }

    public void checkHighScore(){
        if(playerScore > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", playerScore);
            updateHighScore();
        }
    }

    public void updateHighScore(){
        HighScore.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        updateHighScore();
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

}
