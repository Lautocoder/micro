<<<<<<< HEAD
using System;

=======
>>>>>>> 042dabc88c691e7447534d91fa9f6eea7c746229
namespace Play.Catalog.Contracts
{
    public record CatalogItemCreated(Guid ItemId, string Name, string Description);

    public record CatalogItemUpdated(Guid ItemId, string Name, string Description);

    public record CatalogItemDeleted(Guid ItemId);
}