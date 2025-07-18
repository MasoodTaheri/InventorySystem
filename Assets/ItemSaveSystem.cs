using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ItemSaveSystem
{
    private const string SAVE_KEY = "PlayerItems";

    public static void SaveItems(List<ItemCount> items)
    {
        string json = JsonUtility.ToJson(new ItemListWrapper(items));
        PlayerPrefs.SetString(SAVE_KEY, json);
        PlayerPrefs.Save(); 
    }

    public static List<ItemCount> LoadItems()
    {
        if (PlayerPrefs.HasKey(SAVE_KEY))
        {
            string json = PlayerPrefs.GetString(SAVE_KEY);
            return JsonUtility.FromJson<ItemListWrapper>(json).items;
        }
        return new List<ItemCount>(); 
    }

    [System.Serializable]
    private class ItemListWrapper
    {
        public List<ItemCount> items;
        public ItemListWrapper(List<ItemCount> items) => this.items = items;
    }

    public static void UpdateItem(string itemId, int addCount)
    {
        Debug.Log($"{itemId}X{addCount} bought");
        var items = LoadItems();
        var existing = items.FirstOrDefault(x => x.itemId == itemId);

        if (existing != null)
        {
            existing.count += addCount;
        }
        else
        {
            items.Add(new ItemCount(itemId, addCount));
        }

        SaveItems(items);
    }
}