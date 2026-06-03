using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAim : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    private Vector2 lastAimDirection = Vector2.up;

    void Update()
    {
        Vector2 aimDirection = Vector2.zero;

        if (joystick != null && joystick.InputValue.magnitude > 0.1f)
        {
            aimDirection = joystick.InputValue;
        }
        else
        {
            #if !UNITY_ANDROID && !UNITY_IOS
            Vector2 mouseScreen = Mouse.current.position.ReadValue();
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(mouseScreen);
            mousePos.z = 0f;
            aimDirection = (Vector2)(mousePos - transform.position);
            #endif
        }

        if (aimDirection.magnitude < 0.1f)
        {
            aimDirection = lastAimDirection;
        }
        else
        {
            lastAimDirection = aimDirection;
        }

        aimDirection.Normalize();
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}