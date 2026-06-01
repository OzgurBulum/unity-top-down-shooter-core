using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;

    [Header("Movement")]
    public float moveSpeed = 5f;

    [Header("Shooting")]
    public float fireRate = 0.3f;
    public int bulletDamage = 1;

    void Awake()
    {
        // TODO: Singleton kur
        Instance = this;
    }
}