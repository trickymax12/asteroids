using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    private int score;
    public int lives;
    public TextMeshProUGUI ScoreDisplay;
    public TextMeshProUGUI LifeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
        lives = 3;
        UpdateLives(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int scoretoadd)
    {
        score += scoretoadd;
        ScoreDisplay.text = $"score:{score}";
    }
    public void UpdateLives(int LivestoMinus)
    {
        lives -= LivestoMinus;
        LifeDisplay.text = $"Lives:{lives}";
    }
    public void OnMouseDown()
    {
        SceneManager.LoadScene("title");
    }
}
