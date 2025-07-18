using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPresenter : MonoBehaviour
{

    [SerializeField] private ItemBaseData _model;
    [SerializeField] private ItemView _view;

    public void Initialize(ItemBaseData model, Action<int> Purchase)
    {
        _model = model;
        _view.Initialize(_model, Purchase);
        _view.SetPerchase(Purchase);
    }
}
