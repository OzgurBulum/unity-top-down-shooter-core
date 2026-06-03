using UnityEngine;

public class SafeArea : MonoBehaviour
{
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        // TODO: Screen.safeArea ile güvenli alanı al
        Rect safeArea = Screen.safeArea;
        // TODO: safeArea'yı Canvas boyutuna göre normalize et
        Vector2 anchorMin = safeArea.position;
        Vector2 anchorMax = safeArea.position + safeArea.size;
        // TODO: rectTransform'un anchorMin ve anchorMax değerlerini ayarla
        anchorMin.x = anchorMin.x / Screen.width;
        anchorMin.y = anchorMin.y / Screen.height;
        anchorMax.x = anchorMax.x / Screen.width;
        anchorMax.y = anchorMax.y / Screen.height;
        rectTransform.anchorMin = anchorMin;
        rectTransform.anchorMax = anchorMax;
    }
}