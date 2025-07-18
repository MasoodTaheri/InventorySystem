using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{

    [SerializeField] private int _userCoin;
    [SerializeField] private ShopManager _shopManager;
    [SerializeField] private InventoryManager _inventoryManager;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private MenuManager _menuManager;
    void Start()
    {
        _shopManager.Initialize();
        _inventoryManager.GetAllItems();
        _gameManager.SetState(GameState.Game);
        _menuManager.SetCoin(_userCoin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
