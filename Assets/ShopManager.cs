using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private List<ItemBaseData> _availableItems;

    public void Initialize()
    {
        _availableItems = new List<ItemBaseData>();
        _availableItems.AddRange(Resources.LoadAll<ItemBaseData>("Data/ShopItems"));
    }

    public List<ItemBaseData> GetAllItems()
    {
        return _availableItems;
    }
}
