using System;

namespace Assets.Scripts.UI.Purchase
{
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
}