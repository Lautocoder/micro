using System;
using Play.Common;

namespace Play.Inventory.Service.Entities
{
    public class CatalogItem : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

<<<<<<< HEAD
        public string Description { get; set; } 
=======
        public string Desctiption { get; set; } 
>>>>>>> main
    }
}