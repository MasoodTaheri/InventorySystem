using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI.Inventory
{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField] private List<ItemCount> items = new List<ItemCount>();
        internal List<ItemCount> GetAllItems()
        {
            items.Clear();
            items.AddRange(ItemSaveSystem.LoadItems());
            return items;
        }
    }
}