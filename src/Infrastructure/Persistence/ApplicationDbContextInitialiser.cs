using Cherpumple.Domain.Entities;
using Cherpumple.Domain.Enums;
using Cherpumple.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Cherpumple.Infrastructure.Persistence;

public class ApplicationDbContextInitialiser
{
    private readonly ILogger<ApplicationDbContextInitialiser> _logger;
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public ApplicationDbContextInitialiser(ILogger<ApplicationDbContextInitialiser> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _logger = logger;
        _context = context;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task InitialiseAsync()
    {
        try
        {
            if (_context.Database.IsSqlServer())
            {
                await _context.Database.MigrateAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }

    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    public async Task TrySeedAsync()
    {
        // Default roles
        var administratorRole = new IdentityRole("Administrator");

        if (_roleManager.Roles.All(r => r.Name != administratorRole.Name))
        {
            await _roleManager.CreateAsync(administratorRole);
        }

        // Default users
        var administrator = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

        if (_userManager.Users.All(u => u.UserName != administrator.UserName))
        {
            await _userManager.CreateAsync(administrator, "Administrator1!");
            await _userManager.AddToRolesAsync(administrator, new[] { administratorRole.Name });
        }

        if (!_context.Recipes.Any())
        {
            var ingredientsList = new List<Ingredient>() 
            {
                new ()
                {
                    Name = "Hvidløg",
                    FoodGroup = FoodGroup.Spice,
                    ClarificationText = "Maa man stadig godt kalde det 'fed'?",
                    Unit = MeasurementUnit.Clove,
                    Quantity = 4
                }, 
                new ()
                {
                    Name = "Kylling",
                    FoodGroup = FoodGroup.Meat,
                    ClarificationText = "Its aliiiive!",
                    Unit = MeasurementUnit.Kilograms,
                    Quantity = 2,
                },
                new ()
                {
                    Name = "Ris",
                    Quantity = 3,
                    FoodGroup = FoodGroup.Carbohydrates,
                    ClarificationText = "",
                    Unit = MeasurementUnit.Kilograms
                }
            };

            var directionsList = new List<Direction>()
            {
                new Direction()
                {
                    Description = "Peberfrugt, løg, chili og bladselleri skæres/snittes i små stykker",
                    Step = 1
                },
                new Direction()
                {
                    Description = "Forårsløg snittes i tynde skiver og persillen hakkes fint. Disse skal bruges til pynt til sidst i retten.",
                    Step = 2
                },
                new Direction()
                {
                    Description = "Chorizo skæres i skiver, gerne et par milimeter tykke så der er lidt bid",
                    Step = 3
                },
                new Direction()
                {
                    Description = "Du færdiggør retten, fjolle",
                    Step = 4
                }
            };

            var author = new Author()
            {
                FirstName = "lille",
                LastName = "Søster",
            };

            var kitchenTools = new KitchenTool() { Name = "Gryde" };
            
            await _context.Recipes.AddAsync(new()
            {
                Title = "Jambalaya: Sydens Biksemad",
                DifficultyLevel = DifficultyLevel.Easy,
                Category = Category.Dinner,
                DurationCooking = "25 min",
                DurationPreparation = "15 min",
                Region = Region.American,
                Serves = 4,
                Author = author,
                Ingredients = ingredientsList,
                Directions = directionsList,
                Description = "This is a description",
                Notes = "no notes"
                
            });

            var res = await _context.SaveChangesAsync();
        }
    }
}
