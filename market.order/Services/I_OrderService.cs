namespace market.order.Services
{
    public interface I_OrderService
    {
        List<Models.Order> GetItems();
        Models.Order GetItem(int id);
        Models.Order AddItem(Models.Order item);
        Models.Order UpdateItem(Models.Order item);   
        bool DeleteItem(int id);
    };
}
