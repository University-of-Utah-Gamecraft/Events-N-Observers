using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float score = 0f;
    private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();  
    }

    private void OnEnable()
    {
        Actions.AddScore += UpdateScore;
    }

    private void OnDisable()
    {
        Actions.AddScore -= UpdateScore;
    }

    public void UpdateScore(int amt) 
    {
        score += amt;
        scoreText.SetText("Score: " +  score);

    }
}
