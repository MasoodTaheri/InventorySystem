using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseView : MonoBehaviour
{
    [SerializeField] private TMP_Text _description;
    [SerializeField] private Button _purchaseButton;
    [SerializeField] private int id;


    public void Initialize(PurchaseModel model)
    {
        id = model.ItemId;
        _description.text = $"Do you want to purchase\r\n {model.ItemName}\r\n for {model.Price}?";
        _purchaseButton.onClick.RemoveAllListeners();
        _purchaseButton.onClick.AddListener(() =>
        {
            /*if (model.userCoinCount > int.Parse(model.Price))
            {
                model.Purchase?.Invoke(id);
                model.PurchaseFeedback?.Invoke("Payment is successful");
            }
            else
            {
                model.PurchaseFeedback?.Invoke("Payment failed.\r\nYou have not enough coin");
            }
            */
            model.Purchase?.Invoke(id);
        });

    }

}
