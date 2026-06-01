using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance;

    [SerializeField] private GameObject upgradePanel;

    void Awake()
    {
        // TODO: Singleton kur
        Instance = this;
    }

    public void ShowUpgradePanel()
    {
        // TODO: upgradePanel'i aktif et
        upgradePanel.SetActive(true);
        // TODO: Time.timeScale'i 0 yap
        Time.timeScale = 0f;
    }

    public void SelectFireRate()
    {
        // TODO: PlayerStats.Instance.fireRate'i azalt (daha hızlı ateş)
        PlayerStats.Instance.fireRate *= 0.9f; // Örneğin, %10 azaltma
        // TODO: minimum limit koy, 0.05f'den küçük olmasın
        PlayerStats.Instance.fireRate = Mathf.Max(PlayerStats.Instance.fireRate, 0.05f);
        // TODO: ClosePanel çağır
        ClosePanel();
    }

    public void SelectDamage()
    {
        // TODO: PlayerStats.Instance.bulletDamage'ı 1 artır
        PlayerStats.Instance.bulletDamage += 1;
        // TODO: ClosePanel çağır
        ClosePanel();
    }

    public void SelectSpeed()
    {
        // TODO: PlayerStats.Instance.moveSpeed'i artır
        PlayerStats.Instance.moveSpeed += 0.5f;
        // TODO: ClosePanel çağır
        ClosePanel();
    }

    private void ClosePanel()
    {
        // TODO: upgradePanel'i kapat
        upgradePanel.SetActive(false);
        // TODO: Time.timeScale'i 1 yap
        Time.timeScale = 1f;
        // TODO: WaveManager'a yeni wave başlat
        WaveManager.Instance.StartWave();
    }
}