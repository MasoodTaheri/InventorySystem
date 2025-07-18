using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public enum GameState { None, Shop, Inventory, Feedback, Game }


public class GameManager : MonoBehaviour
{
    public GameState CurrentState;
    public static event Action<GameState> OnStateChanged;

    public void SetState(GameState newState)
    {
        if (CurrentState == newState) return;

        CurrentState = newState;

        OnStateChanged?.Invoke(newState);

        Debug.Log($"State changed to {CurrentState}");
    }

    public void SetShopState()=>SetState(GameState.Shop);
    public void SetInventoryState()=>SetState(GameState.Inventory);
    public void SetGameState()=>SetState(GameState.Game);
}
