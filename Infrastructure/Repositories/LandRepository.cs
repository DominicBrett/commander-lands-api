using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class LandRepository : ILandRepository
    {
        private ICollection<LandData> _lands { get; } = [];

        public LandRepository()
        {
            _lands = new List<LandData>()
{
    // Priority 1 – True Duals (ABUR)
    new LandData()
    {
        Name = "Tundra",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },
    new LandData()
    {
        Name = "Underground Sea",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },
    new LandData()
    {
        Name = "Badlands",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },
    new LandData()
    {
        Name = "Taiga",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },
    new LandData()
    {
        Name = "Savannah",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },
    new LandData()
    {
        Name = "Scrubland",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },
    new LandData()
    {
        Name = "Volcanic Island",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },
    new LandData()
    {
        Name = "Tropical Island",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },
    new LandData()
    {
        Name = "Bayou",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },
    new LandData()
    {
        Name = "Plateau",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "True Dual", Priority = 1 }
    },

    // Priority 2 – Fetchlands
    new LandData()
    {
        Name = "Flooded Strand",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },
    new LandData()
    {
        Name = "Polluted Delta",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },
    new LandData()
    {
        Name = "Bloodstained Mire",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },
    new LandData()
    {
        Name = "Wooded Foothills",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },
    new LandData()
    {
        Name = "Windswept Heath",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },
    new LandData()
    {
        Name = "Marsh Flats",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },
    new LandData()
    {
        Name = "Scalding Tarn",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },
    new LandData()
    {
        Name = "Misty Rainforest",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },
    new LandData()
    {
        Name = "Verdant Catacombs",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },
    new LandData()
    {
        Name = "Arid Mesa",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Fetchland", Priority = 2 }
    },

    // Priority 3 – Shocklands
    new LandData()
    {
        Name = "Hallowed Fountain",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
    new LandData()
    {
        Name = "Watery Grave",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
    new LandData()
    {
        Name = "Blood Crypt",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
    new LandData()
    {
        Name = "Stomping Ground",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
    new LandData()
    {
        Name = "Temple Garden",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
    new LandData()
    {
        Name = "Godless Shrine",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
    new LandData()
    {
        Name = "Steam Vents",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
    new LandData()
    {
        Name = "Breeding Pool",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
    new LandData()
    {
        Name = "Overgrown Tomb",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
    new LandData()
    {
        Name = "Sacred Foundry",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Shockland", Priority = 3 }
    },
        // Priority 4 – Bond Lands (Battlebond)
    new LandData()
    {
        Name = "Sea of Clouds",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },
    new LandData()
    {
        Name = "Morphic Pool",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },
    new LandData()
    {
        Name = "Luxury Suite",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },
    new LandData()
    {
        Name = "Spire Garden",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },
    new LandData()
    {
        Name = "Bountiful Promenade",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },
    new LandData()
    {
        Name = "Vault of Champions",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },
    new LandData()
    {
        Name = "Training Center",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },
    new LandData()
    {
        Name = "Undergrowth Stadium",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },
    new LandData()
    {
        Name = "Spectator Seating",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },
    new LandData()
    {
        Name = "Rejuvenating Spring",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Bond Land", Priority = 4 }
    },

    // Priority 5 – Triomes (and other fetchable Tri-lands)
    new LandData()
    {
        Name = "Raugrin Triome",
        Colors = new[] { "white", "blue", "red" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },
    new LandData()
    {
        Name = "Indatha Triome",
        Colors = new[] { "white", "black", "green" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },
    new LandData()
    {
        Name = "Ketria Triome",
        Colors = new[] { "blue", "red", "green" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },
    new LandData()
    {
        Name = "Savai Triome",
        Colors = new[] { "red", "white", "black" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },
    new LandData()
    {
        Name = "Zagoth Triome",
        Colors = new[] { "black", "green", "blue" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },
    new LandData()
    {
        Name = "Jetmir's Garden",
        Colors = new[] { "red", "green", "white" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },
    new LandData()
    {
        Name = "Spara's Headquarters",
        Colors = new[] { "green", "white", "blue" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },
    new LandData()
    {
        Name = "Xander's Lounge",
        Colors = new[] { "blue", "black", "red" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },
    new LandData()
    {
        Name = "Ziatora's Proving Ground",
        Colors = new[] { "black", "red", "green" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },
    new LandData()
    {
        Name = "Raffine's Tower",
        Colors = new[] { "white", "blue", "black" },
        Type = new LandType() { Name = "Triome", Priority = 5 }
    },

    // Priority 6 – Checklands
    new LandData()
    {
        Name = "Glacial Fortress",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
    new LandData()
    {
        Name = "Drowned Catacomb",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
    new LandData()
    {
        Name = "Dragonskull Summit",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
    new LandData()
    {
        Name = "Rootbound Crag",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
    new LandData()
    {
        Name = "Sunpetal Grove",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
    new LandData()
    {
        Name = "Isolated Chapel",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
    new LandData()
    {
        Name = "Sulfur Falls",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
    new LandData()
    {
        Name = "Hinterland Harbor",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
    new LandData()
    {
        Name = "Woodland Cemetery",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
    new LandData()
    {
        Name = "Clifftop Retreat",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Checkland", Priority = 6 }
    },
        // Priority 7 – Painlands
    new LandData()
    {
        Name = "Adarkar Wastes",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },
    new LandData()
    {
        Name = "Underground River",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },
    new LandData()
    {
        Name = "Sulfurous Springs",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },
    new LandData()
    {
        Name = "Karplusan Forest",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },
    new LandData()
    {
        Name = "Brushland",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },
    new LandData()
    {
        Name = "Caves of Koilos",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },
    new LandData()
    {
        Name = "Shivan Reef",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },
    new LandData()
    {
        Name = "Llanowar Wastes",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },
    new LandData()
    {
        Name = "Battlefield Forge",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },
    new LandData()
    {
        Name = "Yavimaya Coast",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Painland", Priority = 7 }
    },

    // Priority 8 – Fastlands
    new LandData()
    {
        Name = "Seachrome Coast",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },
    new LandData()
    {
        Name = "Darkslick Shores",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },
    new LandData()
    {
        Name = "Bloodfell Caves",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },
    new LandData()
    {
        Name = "Inspiring Vantage",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },
    new LandData()
    {
        Name = "Botanical Sanctum",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },
    new LandData()
    {
        Name = "Cinder Glade",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },
    new LandData()
    {
        Name = "Glacial Fortress",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },
    new LandData()
    {
        Name = "Hinterland Harbor",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },
    new LandData()
    {
        Name = "Clifftop Retreat",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },
    new LandData()
    {
        Name = "Woodland Cemetery",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Fastland", Priority = 8 }
    },

    // Priority 9 – Pathways
    new LandData()
    {
        Name = "Hengegate Pathway",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
    new LandData()
    {
        Name = "Clearwater Pathway",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
    new LandData()
    {
        Name = "Blightstep Pathway",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
    new LandData()
    {
        Name = "Boulderloft Pathway",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
    new LandData()
    {
        Name = "Branchloft Pathway",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
    new LandData()
    {
        Name = "Grimclimb Pathway",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
    new LandData()
    {
        Name = "Riverglide Pathway",
        Colors = new[] { "blue", "green" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
    new LandData()
    {
        Name = "Shambling Vent",
        Colors = new[] { "black", "white" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
    new LandData()
    {
        Name = "Sundown Pathway",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
    new LandData()
    {
        Name = "Brightclimb Pathway",
        Colors = new[] { "white", "green" },
        Type = new LandType() { Name = "Pathway", Priority = 9 }
    },
        // Priority 10 – Slowlands
    new LandData()
    {
        Name = "Deserted Beach",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },
    new LandData()
    {
        Name = "Dismal Backwater",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },
    new LandData()
    {
        Name = "Smoldering Marsh",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },
    new LandData()
    {
        Name = "Cinder Barrens",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },
    new LandData()
    {
        Name = "Tranquil Expanse",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },
    new LandData()
    {
        Name = "Forsaken Sanctuary",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },
    new LandData()
    {
        Name = "Shivan Reef",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },
    new LandData()
    {
        Name = "Jungle Hollow",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },
    new LandData()
    {
        Name = "Clifftop Retreat",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },
    new LandData()
    {
        Name = "Yavimaya Coast",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Slowland", Priority = 10 }
    },

    // Priority 11 – Filter Lands
    new LandData()
    {
        Name = "Mystic Gate",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },
    new LandData()
    {
        Name = "Cascade Bluffs",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },
    new LandData()
    {
        Name = "Graven Cairns",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },
    new LandData()
    {
        Name = "Sunken Ruins",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },
    new LandData()
    {
        Name = "Mystifying Maze",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },
    new LandData()
    {
        Name = "Twilight Mire",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },
    new LandData()
    {
        Name = "Sunken Ruins",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },
    new LandData()
    {
        Name = "Twilight Mire",
        Colors = new[] { "white", "green" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },
    new LandData()
    {
        Name = "Graven Cairns",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },
    new LandData()
    {
        Name = "Mystifying Maze",
        Colors = new[] { "blue", "green" },
        Type = new LandType() { Name = "Filter Land", Priority = 11 }
    },

    // Priority 12 – Temples (Scrylands)
    new LandData()
    {
        Name = "Temple of Enlightenment",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },
    new LandData()
    {
        Name = "Temple of Malice",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },
    new LandData()
    {
        Name = "Temple of Mystery",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },
    new LandData()
    {
        Name = "Temple of Abandon",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },
    new LandData()
    {
        Name = "Temple of Silence",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },
    new LandData()
    {
        Name = "Temple of Triumph",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },
    new LandData()
    {
        Name = "Temple of Deceit",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },
    new LandData()
    {
        Name = "Temple of Plenty",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },
    new LandData()
    {
        Name = "Temple of Epiphany",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },
    new LandData()
    {
        Name = "Temple of Malady",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Scryland", Priority = 12 }
    },

    // Priority 13 – Gainlands
    new LandData()
    {
        Name = "Tranquil Cove",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },
    new LandData()
    {
        Name = "Forsaken Sanctuary",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },
    new LandData()
    {
        Name = "Dragonskull Summit",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },
    new LandData()
    {
        Name = "Clifftop Retreat",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },
    new LandData()
    {
        Name = "Blooming Marsh",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },
    new LandData()
    {
        Name = "Scoured Barrens",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },
    new LandData()
    {
        Name = "Stone Quarry",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },
    new LandData()
    {
        Name = "Jungle Hollow",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },
    new LandData()
    {
        Name = "Sejiri Steppe",
        Colors = new[] { "white", "green" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },
    new LandData()
    {
        Name = "Shambling Vent",
        Colors = new[] { "black", "white" },
        Type = new LandType() { Name = "Gainland", Priority = 13 }
    },

    // Priority 14 – Guildgates
    new LandData()
    {
        Name = "Azorius Guildgate",
        Colors = new[] { "white", "blue" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    },
    new LandData()
    {
        Name = "Dimir Guildgate",
        Colors = new[] { "blue", "black" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    },
    new LandData()
    {
        Name = "Rakdos Guildgate",
        Colors = new[] { "black", "red" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    },
    new LandData()
    {
        Name = "Gruul Guildgate",
        Colors = new[] { "red", "green" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    },
    new LandData()
    {
        Name = "Selesnya Guildgate",
        Colors = new[] { "green", "white" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    },
    new LandData()
    {
        Name = "Orzhov Guildgate",
        Colors = new[] { "white", "black" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    },
    new LandData()
    {
        Name = "Izzet Guildgate",
        Colors = new[] { "blue", "red" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    },
    new LandData()
    {
        Name = "Golgari Guildgate",
        Colors = new[] { "black", "green" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    },
    new LandData()
    {
        Name = "Boros Guildgate",
        Colors = new[] { "red", "white" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    },
    new LandData()
    {
        Name = "Simic Guildgate",
        Colors = new[] { "green", "blue" },
        Type = new LandType() { Name = "Guildgate", Priority = 14 }
    }
};
        }
        public List<LandData> GetLands(string[] producesAny, string[] doesNotProduceAny)
        {
            return [.. _lands.Where(x => x.Colors.ContainsAny(producesAny) && x.Colors.DoesNotContainsAny(doesNotProduceAny))];
        }
    }

}