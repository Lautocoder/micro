using Play.Inventory.Service.Dtos;
using Play.Inventory.Service.Entities;

namespace Play.Inventory.Service
{
    public static class Extensions
    {
        public static InventorytemDto AsDto(this InventoryItem item, string name, string description)
        {
            return new InventorytemDto(item.CatalogItemId, name, description, item.Quantity, item.AcquiredDate);
        }
    }
   
}