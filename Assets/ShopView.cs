using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopView : MonoBehaviour
{
    [SerializeField] private GameObject shopRoot;

    internal void AddItem(ItemPresenter temp)
    {
        temp.gameObject.transform.SetParent(shopRoot.transform);
    }
}
