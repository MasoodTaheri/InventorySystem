using Assets.Scripts.UI.Shop;
using Assets.Scripts.UI.ShopItem;
using Assets.Scripts.UI.ShopItem.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI.Inventory
{
    public class InventoryPanel : UIPanel
    {
        [SerializeField] private ShopView _view;
        [SerializeField] private InventoryItemPresenter _shopItemPrefab;
        [SerializeField] private ShopManager _shopManager;
        [SerializeField] private InventoryManager _inventoryManager;
        [SerializeField] private List<ItemPresenter> _items;
        public override void Show()
        {
            base.Show();
            var allItems = _inventoryManager.GetAllItems();
            if (_items != null && _items.Count > 0)
            {
                while (_items.Count > 0)
                {
                    Destroy(_items[0].gameObject);
                    _items.RemoveAt(0);
                }
            }
            foreach (var item in allItems)
            {
                var shopItem = GetItemById(int.Parse(item.itemId));
                var temp = Instantiate(_shopItemPrefab);
                temp.Initialize(shopItem, item.count);
                _items.Add(temp);
                _view.AddItem(temp);
            }
        }

        private ItemBaseData GetItemById(int id)
        {
            var items = _shopManager.GetAllItems();
            foreach (var item in items)
            {
                if (item.id == id)
                    return item;
            }
            return null;
        }
    }
}