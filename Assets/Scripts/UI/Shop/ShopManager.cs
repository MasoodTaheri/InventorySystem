using Assets.Scripts.UI.ShopItem.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI.Shop
{
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
}