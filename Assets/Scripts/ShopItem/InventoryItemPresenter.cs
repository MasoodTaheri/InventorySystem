using UnityEngine;

public class InventoryItemPresenter:ItemPresenter
{
    [SerializeField] protected InventoryItemView _view;
    public void Initialize(ItemBaseData model, int count)
    {
        _model = model;
        _view.InventoryInitialize(_model, count);
    }
}