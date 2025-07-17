using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPresenter : MonoBehaviour
{

    [SerializeField] private ItemBaseData _model;
    [SerializeField] private ItemView _view;
    public Action<int> Purchase;

    private void OnEnable()
    {
        _view.Initialize(_model, Purchase);
    }
    public void Initialize()
    {
        _view.SetPerchase(Purchase);
    }
}
