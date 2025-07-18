using System;
using UnityEngine;

public class ShopItemPresenter:ItemPresenter
{
    [SerializeField] protected ShopItemView _view;
    public void Initialize(ItemBaseData model, Action<int> Purchase)
    {
        _model = model;
        _view.ShopInitialize(_model, Purchase);
        _view.SetPerchase(Purchase);
    }
}
