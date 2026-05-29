using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public static ScoreUI Instance;
    
    [SerializeField] private TextMeshProUGUI scoreText;

    void Awake()
    {
        // TODO: Singleton kur
        Instance = this;
    }

    public void UpdateScore(int score)
    {
        // TODO: scoreText'i güncelle
        scoreText.text = "Score: " + score.ToString();
    }
}