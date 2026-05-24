using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager Instance;

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private int enemiesPerWave = 5;
    [SerializeField] private float timeBetweenSpawns = 1f;

    private int currentWave = 0;
    private int enemiesAlive = 0;
    private int enemiesSpawned = 0;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        StartWave();
    }

    void StartWave()
    {
        currentWave++;
        enemiesSpawned = 0;
        InvokeRepeating(nameof(SpawnEnemy), 0f, timeBetweenSpawns);
    }

    void SpawnEnemy()
    {
        if (enemiesSpawned >= enemiesPerWave)
        {
            CancelInvoke(nameof(SpawnEnemy));
            return;
        }

        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefab, spawnPoints[index].position, Quaternion.identity);
        enemiesAlive++;
        enemiesSpawned++;
    }

    public void OnEnemyDied()
    {
        enemiesAlive--;
        if (enemiesAlive <= 0 && enemiesSpawned >= enemiesPerWave)
        {
            StartWave();
        }
    }
}