using System;

[Serializable]
public class PurchaseModel
{
    public int ItemId;
    public string ItemName;
    public string Price;
    public Action<int> Purchase;
    public int userCoinCount;
    public Action<string> PurchaseFeedback;
}
