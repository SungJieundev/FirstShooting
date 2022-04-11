using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance //ΩÃ±€≈Ê ∆–≈œ get set
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreManager>();
            }
            return instance;
        }

    }

    [SerializeField] Text scoreText;

    public static ScoreManager instance;
    public int score = 0;

    private void Update()
    {
        ScoreCount();
    }

    public void Plusscore()
    {
        score++;
    }

    void ScoreCount()
    {
        scoreText.text = "Score : " + score;
    }

}
