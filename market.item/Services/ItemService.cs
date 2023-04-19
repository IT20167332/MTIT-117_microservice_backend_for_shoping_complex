using market.item.Data;
using market.item.Models;

namespace market.item.Services
{
    public class ItemService : I_ItemService
    {
        public Models.Item? AddItem(Models.Item item)
        {
            ItemDataService.items.Add(item);
            return item;
        }

        public bool DeleteItem(int id)
        {
            Item itemToDelete = ItemDataService.items.FirstOrDefault(i => i.Id == id);
            if (itemToDelete != null)
            {
                ItemDataService.items.Remove(itemToDelete);
                return true;
            }
            return false;
        }

        public List<Models.Item> GetItems ()
        {
            return ItemDataService.items;
        }

        public Models.Item? GetItem(int id)
        {
            return ItemDataService.items.FirstOrDefault(i => i.Id == id);
        }

        public Models.Item? UpdateItem(Item item)
        {
            Item existingItem = ItemDataService.items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Name = item.Name;
                existingItem.Price = item.Price;
                existingItem.Description = item.Description;
            }
            return existingItem;
        }
    }
}
