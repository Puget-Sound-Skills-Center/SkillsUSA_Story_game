using UnityEngine;

public class ClickRawImageToChangeText : MonoBehaviour
{
    public string customMessage;

    // NEW: deactivate these when clicked
    public GameObject[] objectsToDeactivate;

    // OPTIONAL: activate these when clicked
    public GameObject[] objectsToActivate;

    // OPTIONAL: hierarchy activation (from earlier)
    public int hierarchyIndex;
    public HierarchyActivator hierarchyActivator;

    public void OnClick()
    {
        UpdateTexts();
    }

    public void SetCustomMessage(string msg)
    {
        customMessage = msg;
    }

    public void UpdateTexts()
    {
        Debug.Log("Clicked: " + customMessage);

        if (TextDisplayManager.Instance != null)
        {
            TextDisplayManager.Instance.ShowMessage(customMessage);
        }
        else
        {
            Debug.LogError("TextDisplayManager.Instance is NULL!");
        }

        // Activate hierarchy item
        if (hierarchyActivator != null)
        {
            hierarchyActivator.ActivateItem(hierarchyIndex);
        }

        // Deactivate specific objects
        foreach (GameObject obj in objectsToDeactivate)
        {
            if (obj != null)
                obj.SetActive(false);
        }

        // Activate specific objects (optional)
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
                obj.SetActive(true);
        }
    }
}
