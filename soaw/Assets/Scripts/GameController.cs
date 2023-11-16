using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int totalScoreAzul;
    public int totalScoreAmarelo;
    public int totalScoreVerde;

    public TextMeshProUGUI scoreTextAzul;
    public TextMeshProUGUI scoreTextAmarelo;
    public TextMeshProUGUI scoreTextVerde;
    public static GameController instance;
    void Start()
    {
        instance = this;
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
}
