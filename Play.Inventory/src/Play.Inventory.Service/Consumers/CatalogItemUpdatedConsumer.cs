using MassTransit;
using Play.Catalog.Contracts;
using Play.Common;
using Play.Inventory.Service.Entities;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Play.Inventory.Service.Consumers
{
    public class CatalogItemUpdatedConsumer : IConsumer<CatalogItemUpdated>
    {
        private readonly IRepository<CatalogItem> repository;

        public CatalogItemUpdatedConsumer(IRepository<CatalogItem> repository)
        {
            this.repository = repository;
        }
        public async Task Consume(ConsumeContext<CatalogItemUpdated> context)
        {
            var message = context.Message;
            var item = await repository.GetAsync(message.ItemId);
            if (item == null)
            {
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
            else
            {
                item.Name = message.Name;
<<<<<<< HEAD
                item.Description = message.Description;
=======
                item.Desctiption = message.Description;
>>>>>>> main

                await repository.UpdateAsync(item);
            }



        }
    }
}
