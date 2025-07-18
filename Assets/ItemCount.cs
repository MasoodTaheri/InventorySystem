[System.Serializable] 
public class ItemCount
{
    public string itemId;
    public int count;

    public ItemCount(string id, int count)
    {
        this.itemId = id;
        this.count = count;
    }
}
