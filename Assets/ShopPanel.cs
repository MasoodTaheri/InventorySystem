using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;

public class ShopPanel : UIPanel
{
    [SerializeField] private ShopView _view;
    [SerializeField] private ShopItemPresenter _shopItemPrefab;
    [SerializeField] private ShopManager _manager;
    [SerializeField] private List<ItemPresenter> _items;

    public override void Show()
    {
        base.Show();
        var allItems = _manager.GetAllItems();
        if ((_items != null) && (_items.Count > 0))
        {
            while (_items.Count > 0)
            {
                Destroy(_items[0].gameObject);
                _items.RemoveAt(0);
            }
        }
        foreach (var item in allItems)
        {
            var temp = Instantiate(_shopItemPrefab);
            temp.Initialize(item,AskToPurchase);
            _items.Add(temp);
            _view.AddItem(temp);
        }
    }

    private void AskToPurchase(int id)
    {
        ItemSaveSystem.UpdateItem(id.ToString(), 1);
    }
}
