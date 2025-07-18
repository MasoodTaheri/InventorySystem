namespace Assets.Scripts.UI.Inventory
{
    [System.Serializable]
    public class ItemCount
    {
        public string itemId;
        public int count;

        public ItemCount(string id, int count)
        {
            itemId = id;
            this.count = count;
        }
    }
}