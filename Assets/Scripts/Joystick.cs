using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private RectTransform handle;
    [SerializeField] private float maxRadius = 50f;

    public Vector2 InputValue { get; private set; }

    public void OnPointerDown(PointerEventData eventData)
    {
        // TODO: OnDrag çağır
        OnDrag(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            rectTransform, 
            eventData.position, 
            eventData.pressEventCamera, 
            out localPoint
        );

        if (localPoint.magnitude > maxRadius)
        {
            localPoint = localPoint.normalized * maxRadius;
        }

        handle.anchoredPosition = localPoint;
        InputValue = localPoint / maxRadius;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // TODO: handle'ı merkeze döndür (Vector2.zero)
        handle.anchoredPosition = Vector2.zero;
        // TODO: InputValue'yu sıfırla
        InputValue = Vector2.zero;
    }
}