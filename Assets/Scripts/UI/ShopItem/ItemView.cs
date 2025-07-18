using Assets.Scripts.UI.ShopItem.Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.ShopItem
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _title;
        [SerializeField] private TMP_Text _description;
        [SerializeField] private Image _image;
        protected int itemid;
        public void Initialize(ItemBaseData data)
        {
            _title.text = data.itemName;
            _description.text = data.description;
            _image.sprite = data.icon;
            itemid = data.id;
        }


    }
}