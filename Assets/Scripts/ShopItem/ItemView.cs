using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private TMP_Text _price;
    [SerializeField] private Image _image;
    [SerializeField] private Button _button;
    private int itemid;
    public void Initialize(ItemBaseData data, Action<int> purchase)
    {
        _title.text = data.itemName;
        _description.text = data.description;
        _price.text = data.price.ToString()+" $";
        _image.sprite = data.icon;
       
        itemid = data.id;
        SetPerchase(purchase);
    }

    public void SetPerchase(Action<int> purchase)
    {
        _button.onClick.RemoveAllListeners();
        _button.onClick.AddListener(() => { purchase?.Invoke(itemid); });
    }
}
