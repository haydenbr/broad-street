using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameObject gameOverCanvas;
   
    public Text scoreText;
    private int m_Score ;
    Animator anim;
  
  
    // Use this for initialization
    void Start () {
        SetScore(m_Score);
        anim = gameOverCanvas.GetComponent<Animator>();
    }

  
    public void SetScore(int Score){
        m_Score = Score;
        scoreText.text = Score.ToString();
    }

    public int GetScore(){
        return m_Score;
    }

    public void StartGame(){
        Time.timeScale = 1;
       
        scoreText.text = "0";
        SceneManager.LoadScene(0);
        gameOverCanvas.SetActive(false);
    }

    public void EndGame(){
     
       gameOverCanvas.SetActive(true);

        Time.timeScale = 0;
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
        anim.SetTrigger("GameOver");

    }


}
