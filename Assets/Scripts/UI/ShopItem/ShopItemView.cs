using Assets.Scripts.UI.ShopItem.Models;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.ShopItem
{
    public class ShopItemView : ItemView
    {
        [SerializeField] private TMP_Text _price;
        [SerializeField] private Button _button;

        public void ShopInitialize(ItemBaseData data, Action<int> purchase)
        {
            Initialize(data);
            _price.text = data.price.ToString() + " $";
            SetPerchase(purchase);

        }
        public void SetPerchase(Action<int> purchase)
        {
            if (_button == null)
                return;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => { purchase?.Invoke(itemid); });
        }
    }
}