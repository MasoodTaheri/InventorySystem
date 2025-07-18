using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasePanel : UIPanel
{
    [SerializeField] private PurchasePresenter _presenter;
    [SerializeField] private feedback _feedback;
    public override void Show()
    {
        base.Show();
        _presenter.gameObject.SetActive(true);
        _feedback.gameObject.SetActive(false);
    }
    public void Initialize(PurchaseModel model)
    {//? "Payment is successful" : "Payment failed"
        model.PurchaseFeedback = (t) =>
        {
            _presenter.gameObject.SetActive(false) ;
            Debug.Log("PurchaseFeedback =" + t);
            _feedback.ShowMessage(t );
        };
        //model.Purchase += (t) => { Hide(); };
        _presenter.Initialize(model);
    }
}
