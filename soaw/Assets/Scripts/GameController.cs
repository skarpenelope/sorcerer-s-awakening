using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Pontuação
    public int totalScoreAzul;
    public int totalScoreAmarelo;
    public int totalScoreVerde;

    public TextMeshProUGUI scoreTextAzul;
    public TextMeshProUGUI scoreTextAmarelo;
    public TextMeshProUGUI scoreTextVerde;
    
    //GAME OVER
    public GameObject gameOver;


    public GameObject Win;
    
    public static GameController instance;
    void Start()
    {
        instance = this;

        VidaDoJogador vida = GetComponent<VidaDoJogador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        scoreTextAzul.text = totalScoreAzul.ToString();

        scoreTextAmarelo.text = totalScoreAmarelo.ToString();

        scoreTextVerde.text = totalScoreVerde.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);

    }

    public void RestartGame(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void UpdateLife()
    {
        
    }
}
