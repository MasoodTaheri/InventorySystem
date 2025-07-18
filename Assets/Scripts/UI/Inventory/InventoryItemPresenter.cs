using Assets.Scripts.UI.ShopItem;
using Assets.Scripts.UI.ShopItem.Models;
using UnityEngine;

namespace Assets.Scripts.UI.Inventory
{
    public class InventoryItemPresenter : ItemPresenter
    {
        [SerializeField] protected InventoryItemView _view;
        public void Initialize(ItemBaseData model, int count)
        {
            _model = model;
            _view.InventoryInitialize(_model, count);
        }
    }
}