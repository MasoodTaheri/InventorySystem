using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasePresenter : MonoBehaviour
{
    [SerializeField] private PurchaseView _view;
    [SerializeField] private PurchaseModel _model;

    public void Initialize(PurchaseModel model)
    {
        _model = model;
        _view.Initialize(_model);
    }

}
