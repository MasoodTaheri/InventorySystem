using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private List<UIPanel> _panels;
    [SerializeField] private List<UIPanel> _lastpanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

    
}
