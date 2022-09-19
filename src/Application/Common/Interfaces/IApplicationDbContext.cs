using Cherpumple.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cherpumple.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Author> Authors { get; }

    DbSet<Direction> Directions { get; }
    
    DbSet<Recipe> Recipes { get; }
    
    DbSet<KitchenTool> KitchenTools { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
