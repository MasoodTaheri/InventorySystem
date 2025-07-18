using Assets.Scripts.UI.Purchase;
using Assets.Scripts.UI.ShopItem;
using Assets.Scripts.UI.ShopItem.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI.Shop
{
    public class ShopPanel : UIPanel
    {
        [SerializeField] private ShopView _view;
        [SerializeField] private ShopItemPresenter _shopItemPrefab;
        [SerializeField] private ShopManager _manager;
        [SerializeField] private List<ItemPresenter> _items;
        [SerializeField] private PurchasePanel _purchasePanel;
        [SerializeField] private int _userCoin = 0;

        public override void Show()
        {
            base.Show();
            var allItems = _manager.GetAllItems();
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
                var temp = Instantiate(_shopItemPrefab);
                temp.Initialize(item, AskToPurchase);
                _items.Add(temp);
                _view.AddItem(temp);
            }
        }

        internal void SetUserCoinCount(int userCoin)
        {
            _userCoin = userCoin;
        }

        private void AskToPurchase(int id)
        {
            PurchaseModel purchaseModel = new PurchaseModel();
            purchaseModel.ItemId = id;
            ItemBaseData itemdata = _manager.GetAllItems().Find(x => x.id == id);
            purchaseModel.ItemName = itemdata.itemName;
            purchaseModel.Price = itemdata.price.ToString();
            purchaseModel.userCoinCount = _userCoin;
            purchaseModel.Purchase = (t) =>
            {
                Debug.Log("try Purchase");
                if (purchaseModel.userCoinCount > int.Parse(purchaseModel.Price))
                {
                    ItemSaveSystem.UpdateItem(id.ToString(), 1);
                    purchaseModel.PurchaseFeedback?.Invoke("Payment is successful");
                }
                else
                {
                    purchaseModel.PurchaseFeedback?.Invoke("Payment failed.\r\nYou have not enough coin");
                }
            };
            _purchasePanel.Show();
            _purchasePanel.Initialize(purchaseModel);

        }
    }
}