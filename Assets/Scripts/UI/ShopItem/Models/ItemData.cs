using UnityEngine;

namespace Assets.Scripts.UI.ShopItem.Models
{
    public class ItemBaseData : ScriptableObject
    {
        public int id;
        public string itemName;
        public Sprite icon;
        public string description;
        public int price;
    }
}