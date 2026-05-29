using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    void OnEnable()
    {
        // TODO: PlayerHealth.OnPlayerDied event'ine abone ol
        PlayerHealth.OnPlayerDied += ShowGameOver;
    }

    void OnDisable()
    {
        // TODO: PlayerHealth.OnPlayerDied aboneliğini iptal et
        PlayerHealth.OnPlayerDied -= ShowGameOver;
    }

    private void ShowGameOver()
    {
        // TODO: gameOverPanel'i aktif et
        gameOverPanel.SetActive(true);
        // TODO: Time.timeScale'i 0 yap
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        // TODO: Time.timeScale'i 1 yap
        Time.timeScale = 1f;
        // TODO: aktif sahneyi yeniden yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}