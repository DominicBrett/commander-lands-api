using Domain.Models;
using Domain.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

public class LandContext : DbContext
{
    public LandContext(DbContextOptions<LandContext> options) : base(options)
    {
    }

    public DbSet<LandData> Lands { get; set; }
    public DbSet<LandType> LandTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Store Colors[] as JSON in a text column
        modelBuilder.Entity<LandData>()
            .Property(e => e.Colors)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                v => JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null));

        // Seed LandTypes
        modelBuilder.Entity<LandType>().HasData(
            new LandType { Id = 1, Name = "True Dual", Priority = 1 },
            new LandType { Id = 2, Name = "Fetchland", Priority = 2 },
            new LandType { Id = 3, Name = "Shockland", Priority = 3 },
            new LandType { Id = 4, Name = "Bond Land", Priority = 4 },
            new LandType { Id = 5, Name = "Triome", Priority = 5 },
            new LandType { Id = 6, Name = "Checkland", Priority = 6 },
            new LandType { Id = 7, Name = "Painland", Priority = 7 },
            new LandType { Id = 8, Name = "Fastland", Priority = 8 },
            new LandType { Id = 9, Name = "Pathway", Priority = 9 },
            new LandType { Id = 10, Name = "Slowland", Priority = 10 },
            new LandType { Id = 11, Name = "Filter Land", Priority = 11 },
            new LandType { Id = 12, Name = "Scryland", Priority = 12 },
            new LandType { Id = 13, Name = "Gainland", Priority = 13 },
            new LandType { Id = 14, Name = "Guildgate", Priority = 14 }
        );

        modelBuilder.Entity<LandData>().HasData(
    // Priority 1 – True Duals (TypeId = 1)
    new LandData { Id = 1, Name = "Tundra", Colors = new[] { "white", "blue" }, TypeId = 1 },
    new LandData { Id = 2, Name = "Underground Sea", Colors = new[] { "blue", "black" }, TypeId = 1 },
    new LandData { Id = 3, Name = "Badlands", Colors = new[] { "black", "red" }, TypeId = 1 },
    new LandData { Id = 4, Name = "Taiga", Colors = new[] { "red", "green" }, TypeId = 1 },
    new LandData { Id = 5, Name = "Savannah", Colors = new[] { "green", "white" }, TypeId = 1 },
    new LandData { Id = 6, Name = "Scrubland", Colors = new[] { "white", "black" }, TypeId = 1 },
    new LandData { Id = 7, Name = "Volcanic Island", Colors = new[] { "blue", "red" }, TypeId = 1 },
    new LandData { Id = 8, Name = "Tropical Island", Colors = new[] { "green", "blue" }, TypeId = 1 },
    new LandData { Id = 9, Name = "Bayou", Colors = new[] { "black", "green" }, TypeId = 1 },
    new LandData { Id = 10, Name = "Plateau", Colors = new[] { "red", "white" }, TypeId = 1 },

    // Priority 2 – Fetchlands (TypeId = 2)
    new LandData { Id = 11, Name = "Flooded Strand", Colors = new[] { "white", "blue" }, TypeId = 2 },
    new LandData { Id = 12, Name = "Polluted Delta", Colors = new[] { "blue", "black" }, TypeId = 2 },
    new LandData { Id = 13, Name = "Bloodstained Mire", Colors = new[] { "black", "red" }, TypeId = 2 },
    new LandData { Id = 14, Name = "Wooded Foothills", Colors = new[] { "red", "green" }, TypeId = 2 },
    new LandData { Id = 15, Name = "Windswept Heath", Colors = new[] { "green", "white" }, TypeId = 2 },
    new LandData { Id = 16, Name = "Marsh Flats", Colors = new[] { "white", "black" }, TypeId = 2 },
    new LandData { Id = 17, Name = "Scalding Tarn", Colors = new[] { "blue", "red" }, TypeId = 2 },
    new LandData { Id = 18, Name = "Misty Rainforest", Colors = new[] { "green", "blue" }, TypeId = 2 },
    new LandData { Id = 19, Name = "Verdant Catacombs", Colors = new[] { "black", "green" }, TypeId = 2 },
    new LandData { Id = 20, Name = "Arid Mesa", Colors = new[] { "red", "white" }, TypeId = 2 },

    // Priority 3 – Shocklands (TypeId = 3)
    new LandData { Id = 21, Name = "Hallowed Fountain", Colors = new[] { "white", "blue" }, TypeId = 3 },
    new LandData { Id = 22, Name = "Watery Grave", Colors = new[] { "blue", "black" }, TypeId = 3 },
    new LandData { Id = 23, Name = "Blood Crypt", Colors = new[] { "black", "red" }, TypeId = 3 },
    new LandData { Id = 24, Name = "Stomping Ground", Colors = new[] { "red", "green" }, TypeId = 3 },
    new LandData { Id = 25, Name = "Temple Garden", Colors = new[] { "green", "white" }, TypeId = 3 },
    new LandData { Id = 26, Name = "Godless Shrine", Colors = new[] { "white", "black" }, TypeId = 3 },
    new LandData { Id = 27, Name = "Steam Vents", Colors = new[] { "blue", "red" }, TypeId = 3 },
    new LandData { Id = 28, Name = "Breeding Pool", Colors = new[] { "green", "blue" }, TypeId = 3 },
    new LandData { Id = 29, Name = "Overgrown Tomb", Colors = new[] { "black", "green" }, TypeId = 3 },
    new LandData { Id = 30, Name = "Sacred Foundry", Colors = new[] { "red", "white" }, TypeId = 3 },

// Priority 4 – Bond Lands (TypeId = 4)
new LandData { Id = 31, Name = "Sea of Clouds", Colors = new[] { "white", "blue" }, TypeId = 4 },
new LandData { Id = 32, Name = "Morphic Pool", Colors = new[] { "blue", "black" }, TypeId = 4 },
new LandData { Id = 33, Name = "Luxury Suite", Colors = new[] { "black", "red" }, TypeId = 4 },
new LandData { Id = 34, Name = "Spire Garden", Colors = new[] { "red", "green" }, TypeId = 4 },
new LandData { Id = 35, Name = "Bountiful Promenade", Colors = new[] { "green", "white" }, TypeId = 4 },
new LandData { Id = 36, Name = "Vault of Champions", Colors = new[] { "white", "black" }, TypeId = 4 },
new LandData { Id = 37, Name = "Training Center", Colors = new[] { "blue", "red" }, TypeId = 4 },
new LandData { Id = 38, Name = "Undergrowth Stadium", Colors = new[] { "black", "green" }, TypeId = 4 },
new LandData { Id = 39, Name = "Spectator Seating", Colors = new[] { "red", "white" }, TypeId = 4 },
new LandData { Id = 40, Name = "Rejuvenating Spring", Colors = new[] { "green", "blue" }, TypeId = 4 },

// Priority 5 – Triomes (TypeId = 5)
new LandData { Id = 41, Name = "Raugrin Triome", Colors = new[] { "white", "blue", "red" }, TypeId = 5 },
new LandData { Id = 42, Name = "Indatha Triome", Colors = new[] { "white", "black", "green" }, TypeId = 5 },
new LandData { Id = 43, Name = "Ketria Triome", Colors = new[] { "blue", "red", "green" }, TypeId = 5 },
new LandData { Id = 44, Name = "Savai Triome", Colors = new[] { "red", "white", "black" }, TypeId = 5 },
new LandData { Id = 45, Name = "Zagoth Triome", Colors = new[] { "black", "green", "blue" }, TypeId = 5 },
new LandData { Id = 46, Name = "Jetmir's Garden", Colors = new[] { "red", "green", "white" }, TypeId = 5 },
new LandData { Id = 47, Name = "Spara's Headquarters", Colors = new[] { "green", "white", "blue" }, TypeId = 5 },
new LandData { Id = 48, Name = "Xander's Lounge", Colors = new[] { "blue", "black", "red" }, TypeId = 5 },
new LandData { Id = 49, Name = "Ziatora's Proving Ground", Colors = new[] { "black", "red", "green" }, TypeId = 5 },
new LandData { Id = 50, Name = "Raffine's Tower", Colors = new[] { "white", "blue", "black" }, TypeId = 5 },

// Priority 6 – Checklands (TypeId = 6)
new LandData { Id = 51, Name = "Glacial Fortress", Colors = new[] { "white", "blue" }, TypeId = 6 },
new LandData { Id = 52, Name = "Drowned Catacomb", Colors = new[] { "blue", "black" }, TypeId = 6 },
new LandData { Id = 53, Name = "Dragonskull Summit", Colors = new[] { "black", "red" }, TypeId = 6 },
new LandData { Id = 54, Name = "Rootbound Crag", Colors = new[] { "red", "green" }, TypeId = 6 },
new LandData { Id = 55, Name = "Sunpetal Grove", Colors = new[] { "green", "white" }, TypeId = 6 },
new LandData { Id = 56, Name = "Isolated Chapel", Colors = new[] { "white", "black" }, TypeId = 6 },
new LandData { Id = 57, Name = "Sulfur Falls", Colors = new[] { "blue", "red" }, TypeId = 6 },
new LandData { Id = 58, Name = "Hinterland Harbor", Colors = new[] { "green", "blue" }, TypeId = 6 },
new LandData { Id = 59, Name = "Woodland Cemetery", Colors = new[] { "black", "green" }, TypeId = 6 },
new LandData { Id = 60, Name = "Clifftop Retreat", Colors = new[] { "red", "white" }, TypeId = 6 },

// Priority 7 – Painlands (TypeId = 7)
new LandData { Id = 61, Name = "Adarkar Wastes", Colors = new[] { "white", "blue" }, TypeId = 7 },
new LandData { Id = 62, Name = "Underground River", Colors = new[] { "blue", "black" }, TypeId = 7 },
new LandData { Id = 63, Name = "Sulfurous Springs", Colors = new[] { "black", "red" }, TypeId = 7 },
new LandData { Id = 64, Name = "Karplusan Forest", Colors = new[] { "red", "green" }, TypeId = 7 },
new LandData { Id = 65, Name = "Brushland", Colors = new[] { "green", "white" }, TypeId = 7 },
new LandData { Id = 66, Name = "Caves of Koilos", Colors = new[] { "white", "black" }, TypeId = 7 },
new LandData { Id = 67, Name = "Shivan Reef", Colors = new[] { "blue", "red" }, TypeId = 7 },
new LandData { Id = 68, Name = "Llanowar Wastes", Colors = new[] { "black", "green" }, TypeId = 7 },
new LandData { Id = 69, Name = "Battlefield Forge", Colors = new[] { "red", "white" }, TypeId = 7 },
new LandData { Id = 70, Name = "Yavimaya Coast", Colors = new[] { "green", "blue" }, TypeId = 7 },

// Priority 8 – Fastlands (TypeId = 8)
new LandData { Id = 71, Name = "Seachrome Coast", Colors = new[] { "white", "blue" }, TypeId = 8 },
new LandData { Id = 72, Name = "Darkslick Shores", Colors = new[] { "blue", "black" }, TypeId = 8 },
new LandData { Id = 73, Name = "Bloodfell Caves", Colors = new[] { "black", "red" }, TypeId = 8 },
new LandData { Id = 74, Name = "Inspiring Vantage", Colors = new[] { "red", "white" }, TypeId = 8 },
new LandData { Id = 75, Name = "Botanical Sanctum", Colors = new[] { "green", "blue" }, TypeId = 8 },
new LandData { Id = 76, Name = "Cinder Glade", Colors = new[] { "red", "green" }, TypeId = 8 },
new LandData { Id = 77, Name = "Glacial Fortress", Colors = new[] { "white", "blue" }, TypeId = 8 },
new LandData { Id = 78, Name = "Hinterland Harbor", Colors = new[] { "green", "blue" }, TypeId = 8 },
new LandData { Id = 79, Name = "Clifftop Retreat", Colors = new[] { "red", "white" }, TypeId = 8 },
new LandData { Id = 80, Name = "Woodland Cemetery", Colors = new[] { "black", "green" }, TypeId = 8 },

// Priority 9 – Pathways (TypeId = 9)
new LandData { Id = 81, Name = "Hengegate Pathway", Colors = new[] { "white", "blue" }, TypeId = 9 },
new LandData { Id = 82, Name = "Clearwater Pathway", Colors = new[] { "blue", "black" }, TypeId = 9 },
new LandData { Id = 83, Name = "Blightstep Pathway", Colors = new[] { "black", "red" }, TypeId = 9 },
new LandData { Id = 84, Name = "Boulderloft Pathway", Colors = new[] { "red", "white" }, TypeId = 9 },
new LandData { Id = 85, Name = "Branchloft Pathway", Colors = new[] { "green", "white" }, TypeId = 9 },
new LandData { Id = 86, Name = "Grimclimb Pathway", Colors = new[] { "red", "green" }, TypeId = 9 },
new LandData { Id = 87, Name = "Riverglide Pathway", Colors = new[] { "blue", "green" }, TypeId = 9 },
new LandData { Id = 88, Name = "Shambling Vent", Colors = new[] { "black", "white" }, TypeId = 9 },
new LandData { Id = 89, Name = "Sundown Pathway", Colors = new[] { "black", "red" }, TypeId = 9 },
new LandData { Id = 90, Name = "Brightclimb Pathway", Colors = new[] { "white", "green" }, TypeId = 9 },

// Priority 10 – Slowlands (TypeId = 10)
new LandData { Id = 91, Name = "Deserted Beach", Colors = new[] { "white", "blue" }, TypeId = 10 },
new LandData { Id = 92, Name = "Dismal Backwater", Colors = new[] { "blue", "black" }, TypeId = 10 },
new LandData { Id = 93, Name = "Smoldering Marsh", Colors = new[] { "black", "red" }, TypeId = 10 },
new LandData { Id = 94, Name = "Cinder Barrens", Colors = new[] { "red", "green" }, TypeId = 10 },
new LandData { Id = 95, Name = "Tranquil Expanse", Colors = new[] { "green", "white" }, TypeId = 10 },
new LandData { Id = 96, Name = "Forsaken Sanctuary", Colors = new[] { "white", "black" }, TypeId = 10 },
new LandData { Id = 97, Name = "Shivan Reef", Colors = new[] { "blue", "red" }, TypeId = 10 },
new LandData { Id = 98, Name = "Jungle Hollow", Colors = new[] { "black", "green" }, TypeId = 10 },
new LandData { Id = 99, Name = "Clifftop Retreat", Colors = new[] { "red", "white" }, TypeId = 10 },
new LandData { Id = 100, Name = "Yavimaya Coast", Colors = new[] { "green", "blue" }, TypeId = 10 },

// Priority 11 – Filter Lands (TypeId = 11)
new LandData { Id = 101, Name = "Mystic Gate", Colors = new[] { "white", "blue" }, TypeId = 11 },
new LandData { Id = 102, Name = "Cascade Bluffs", Colors = new[] { "blue", "black" }, TypeId = 11 },
new LandData { Id = 103, Name = "Graven Cairns", Colors = new[] { "black", "red" }, TypeId = 11 },
new LandData { Id = 104, Name = "Sunken Ruins", Colors = new[] { "blue", "red" }, TypeId = 11 },
new LandData { Id = 105, Name = "Mystifying Maze", Colors = new[] { "red", "green" }, TypeId = 11 },
new LandData { Id = 106, Name = "Twilight Mire", Colors = new[] { "black", "green" }, TypeId = 11 },
new LandData { Id = 107, Name = "Sunken Ruins", Colors = new[] { "white", "black" }, TypeId = 11 },
new LandData { Id = 108, Name = "Twilight Mire", Colors = new[] { "white", "green" }, TypeId = 11 },
new LandData { Id = 109, Name = "Graven Cairns", Colors = new[] { "red", "white" }, TypeId = 11 },
new LandData { Id = 110, Name = "Mystifying Maze", Colors = new[] { "blue", "green" }, TypeId = 11 },

// Priority 12 – Scrylands (TypeId = 12)
new LandData { Id = 111, Name = "Temple of Enlightenment", Colors = new[] { "white", "blue" }, TypeId = 12 },
new LandData { Id = 112, Name = "Temple of Malice", Colors = new[] { "black", "red" }, TypeId = 12 },
new LandData { Id = 113, Name = "Temple of Mystery", Colors = new[] { "green", "blue" }, TypeId = 12 },
new LandData { Id = 114, Name = "Temple of Abandon", Colors = new[] { "red", "white" }, TypeId = 12 },
new LandData { Id = 115, Name = "Temple of Silence", Colors = new[] { "white", "black" }, TypeId = 12 },
new LandData { Id = 116, Name = "Temple of Triumph", Colors = new[] { "red", "white" }, TypeId = 12 },
new LandData { Id = 117, Name = "Temple of Deceit", Colors = new[] { "blue", "black" }, TypeId = 12 },
new LandData { Id = 118, Name = "Temple of Plenty", Colors = new[] { "green", "white" }, TypeId = 12 },
new LandData { Id = 119, Name = "Temple of Epiphany", Colors = new[] { "blue", "red" }, TypeId = 12 },
new LandData { Id = 120, Name = "Temple of Malady", Colors = new[] { "black", "green" }, TypeId = 12 },

// Priority 13 – Gainlands (TypeId = 13)
new LandData { Id = 121, Name = "Tranquil Cove", Colors = new[] { "white", "blue" }, TypeId = 13 },
new LandData { Id = 122, Name = "Forsaken Sanctuary", Colors = new[] { "white", "black" }, TypeId = 13 },
new LandData { Id = 123, Name = "Dragonskull Summit", Colors = new[] { "black", "red" }, TypeId = 13 },
new LandData { Id = 124, Name = "Clifftop Retreat", Colors = new[] { "red", "white" }, TypeId = 13 },
new LandData { Id = 125, Name = "Blooming Marsh", Colors = new[] { "black", "green" }, TypeId = 13 },
new LandData { Id = 126, Name = "Scoured Barrens", Colors = new[] { "white", "black" }, TypeId = 13 },
new LandData { Id = 127, Name = "Stone Quarry", Colors = new[] { "red", "white" }, TypeId = 13 },
new LandData { Id = 128, Name = "Jungle Hollow", Colors = new[] { "black", "green" }, TypeId = 13 },
new LandData { Id = 129, Name = "Sejiri Steppe", Colors = new[] { "white", "green" }, TypeId = 13 },
new LandData { Id = 130, Name = "Shambling Vent", Colors = new[] { "black", "white" }, TypeId = 13 },

// Priority 14 – Guildgates (TypeId = 14)
new LandData { Id = 131, Name = "Azorius Guildgate", Colors = new[] { "white", "blue" }, TypeId = 14 },
new LandData { Id = 132, Name = "Dimir Guildgate", Colors = new[] { "blue", "black" }, TypeId = 14 },
new LandData { Id = 133, Name = "Rakdos Guildgate", Colors = new[] { "black", "red" }, TypeId = 14 },
new LandData { Id = 134, Name = "Gruul Guildgate", Colors = new[] { "red", "green" }, TypeId = 14 },
new LandData { Id = 135, Name = "Selesnya Guildgate", Colors = new[] { "green", "white" }, TypeId = 14 },
new LandData { Id = 136, Name = "Orzhov Guildgate", Colors = new[] { "white", "black" }, TypeId = 14 },
new LandData { Id = 137, Name = "Izzet Guildgate", Colors = new[] { "blue", "red" }, TypeId = 14 },
new LandData { Id = 138, Name = "Golgari Guildgate", Colors = new[] { "black", "green" }, TypeId = 14 },
new LandData { Id = 139, Name = "Boros Guildgate", Colors = new[] { "red", "white" }, TypeId = 14 },
new LandData { Id = 140, Name = "Simic Guildgate", Colors = new[] { "green", "blue" }, TypeId = 14 }


        );
    }
}