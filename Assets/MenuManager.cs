using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private ShopPanel _ShopPanel;
    [SerializeField] private List<UIPanel> _lastpanel;


    public void OpenPanel(UIPanel panel)
    {
        panel.Show();
        _lastpanel.Add(panel);
    }
    public void ClosePanel(UIPanel panel)
    {
        panel.Hide();
        _lastpanel.Remove(panel);
    }

    public void ShowShop()
    {
        OpenPanel(_ShopPanel);
    }

    internal void SetCoin(int userCoin)
    {
        _ShopPanel.SetUserCoinCount(userCoin);
    }
}
