using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ClickRawImageToChangeText : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI targetText; // Assign in Inspector
    private RawImage rawImage;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (targetText != null)
        {
            targetText.text = gameObject.name;
        }
    }
}
