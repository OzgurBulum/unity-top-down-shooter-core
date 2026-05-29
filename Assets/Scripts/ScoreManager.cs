using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    
    private int score = 0;

    void Awake()
    {
        // TODO: Singleton kur
        Instance = this;

    }

    public void AddScore(int amount)
    {
        // TODO: score'u artır
        score += amount;
        // TODO: ScoreUI'a haber ver
        ScoreUI.Instance.UpdateScore(score);
    }

    public int GetScore()
    {
        // TODO: score'u döndür
        return score;
    }
}