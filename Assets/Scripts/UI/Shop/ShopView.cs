using Assets.Scripts.UI.ShopItem;
using UnityEngine;

namespace Assets.Scripts.UI.Shop
{
    public class ShopView : MonoBehaviour
    {
        [SerializeField] private GameObject shopRoot;

        internal void AddItem(ItemPresenter temp)
        {
            temp.gameObject.transform.SetParent(shopRoot.transform);
        }
    }
}