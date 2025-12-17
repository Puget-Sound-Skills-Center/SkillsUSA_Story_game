using UnityEngine;

public class HierarchyActivator : MonoBehaviour
{
    public GameObject[] hierarchyItems;

    public void ActivateItem(int index)
    {
        for (int i = 0; i < hierarchyItems.Length; i++)
        {
            hierarchyItems[i].SetActive(i == index);
        }
    }
}
