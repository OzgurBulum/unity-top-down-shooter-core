using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private Transform firePoint;
    private PlayerControls controls;

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
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = firePoint.up * bulletSpeed;
    }
}
