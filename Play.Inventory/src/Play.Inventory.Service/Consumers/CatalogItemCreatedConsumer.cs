using MassTransit;
using Play.Catalog.Contracts;
using Play.Common;
using Play.Inventory.Service.Entities;
using System.Threading.Tasks;

namespace Play.Inventory.Service.Consumers
{
    public class CatalogItemCreatedConsumer : IConsumer<CatalogItemCreated>
    {
        private readonly IRepository<CatalogItem> repository;

        public CatalogItemCreatedConsumer(IRepository<CatalogItem> repository)
        {
            this.repository = repository;
        }
        public async Task Consume(ConsumeContext<CatalogItemCreated> context)
        {
            var message = context.Message;
            var item = await repository.GetAsync(message.ItemId);
<<<<<<< HEAD
            if (item != null) 
=======
            if (item == null) 
>>>>>>> main
            {
                return;
            }

            item = new CatalogItem
            {
                Id = message.ItemId,
                Name = message.Name,
<<<<<<< HEAD
                Description = message.Description,
=======
                Desctiption = message.Description,
>>>>>>> main
            };

            await repository.CreateAsync(item);

        }
    }
}
