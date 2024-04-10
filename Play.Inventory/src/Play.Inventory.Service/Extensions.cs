using Play.Inventory.Service.Dtos;
using Play.Inventory.Service.Entities;

namespace Play.Inventory.Service
{
    public static class Extensions
    {
        public static InventorytemDto AsDto(this InventoryItem item)
        {
            return new InventorytemDto(item.CatalogItemId, item.Quantity, item.AcquiredDate);
        }
    }
   
}