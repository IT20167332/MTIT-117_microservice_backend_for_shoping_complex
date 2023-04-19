namespace market.item.Services
{
    public interface I_ItemService
    {
        List<Models.Item> GetItems();
        Models.Item GetItem(int id);
        Models.Item AddItem(Models.Item item);
        Models.Item UpdateItem(Models.Item item);   
        bool DeleteItem(int id);
    };
}
