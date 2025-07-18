using TMPro;
using UnityEngine;

public class InventoryItemView : ItemView
{
    [SerializeField] private TMP_Text _count;

    public void InventoryInitialize(ItemBaseData data, int count)
    {
        Initialize(data);
        _count.text = count.ToString();

    }
}
