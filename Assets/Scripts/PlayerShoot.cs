using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private Transform firePoint;
    private PlayerControls controls;
    private float lastFireTime = 0f;

    void Awake()
    {
        controls = new PlayerControls();
    }

    void OnEnable()
    {
        controls.Enable();
        controls.Player.Shoot.performed += OnShootPerformed;
    }

    void OnDisable()
    {
        controls.Player.Shoot.performed -= OnShootPerformed;
        controls.Disable();
    }

    private void OnShootPerformed(InputAction.CallbackContext ctx)
    {
        // TODO: Time.time ile lastFireTime arasındaki fark
        float timeSinceLastFire = Time.time - lastFireTime;
        // PlayerStats.Instance.fireRate'den büyükse ateş et
        if (timeSinceLastFire >= PlayerStats.Instance.fireRate)
        {
            // TODO: bullet oluştur
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            // TODO: bullet'a velocity ver
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.linearVelocity = firePoint.up * bulletSpeed;
            // TODO: bullet'a damage değerini PlayerStats'tan ver
            bullet.GetComponent<Bullet>().damage = PlayerStats.Instance.bulletDamage;
            // TODO: lastFireTime'ı güncelle
            lastFireTime = Time.time;
        } 
    }

    public void OnFireButtonPressed()
    {
        float timeSinceLastFire = Time.time - lastFireTime;
        if (timeSinceLastFire >= PlayerStats.Instance.fireRate)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.linearVelocity = firePoint.up * bulletSpeed;
            bullet.GetComponent<Bullet>().damage = PlayerStats.Instance.bulletDamage;
            lastFireTime = Time.time;
        }
    }

}
