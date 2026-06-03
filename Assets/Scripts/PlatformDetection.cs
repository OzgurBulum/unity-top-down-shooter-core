using UnityEngine;

public class PlatformDetection : MonoBehaviour
{
    void Start()
    {
        // TODO: Android veya iOS ise objeyi aktif et
        #if UNITY_ANDROID || UNITY_IOS
        gameObject.SetActive(true);
        // TODO: değilse deaktif et
        #else
        gameObject.SetActive(false);
        #endif
        // İpucu: #if UNITY_ANDROID || UNITY_IOS compile time direktifi
    }
}