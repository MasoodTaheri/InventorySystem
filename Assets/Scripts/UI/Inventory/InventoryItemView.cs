using Assets.Scripts.UI.ShopItem;
using Assets.Scripts.UI.ShopItem.Models;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.UI.Inventory
{
    public class InventoryItemView : ItemView
    {
        [SerializeField] private TMP_Text _count;

        public void InventoryInitialize(ItemBaseData data, int count)
        {
            Initialize(data);
            _count.text = count.ToString();

        }
    }
}