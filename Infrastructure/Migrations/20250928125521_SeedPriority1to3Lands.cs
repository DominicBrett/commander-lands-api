using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedPriority1to3Lands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LandTypes",
                columns: new[] { "Id", "Name", "Priority" },
                values: new object[,]
                {
                    { 4, "Bond Land", 4 },
                    { 5, "Triome", 5 },
                    { 6, "Checkland", 6 },
                    { 7, "Painland", 7 },
                    { 8, "Fastland", 8 },
                    { 9, "Pathway", 9 },
                    { 10, "Slowland", 10 },
                    { 11, "Filter Land", 11 },
                    { 12, "Scryland", 12 },
                    { 13, "Gainland", 13 },
                    { 14, "Guildgate", 14 }
                });

            migrationBuilder.UpdateData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Colors",
                value: "[\"white\",\"blue\"]");

            migrationBuilder.InsertData(
                table: "Lands",
                columns: new[] { "Id", "Colors", "Name", "TypeId" },
                values: new object[,]
                {
                    { 2, "[\"blue\",\"black\"]", "Underground Sea", 1 },
                    { 3, "[\"black\",\"red\"]", "Badlands", 1 },
                    { 4, "[\"red\",\"green\"]", "Taiga", 1 },
                    { 5, "[\"green\",\"white\"]", "Savannah", 1 },
                    { 6, "[\"white\",\"black\"]", "Scrubland", 1 },
                    { 7, "[\"blue\",\"red\"]", "Volcanic Island", 1 },
                    { 8, "[\"green\",\"blue\"]", "Tropical Island", 1 },
                    { 9, "[\"black\",\"green\"]", "Bayou", 1 },
                    { 10, "[\"red\",\"white\"]", "Plateau", 1 },
                    { 11, "[\"white\",\"blue\"]", "Flooded Strand", 2 },
                    { 12, "[\"blue\",\"black\"]", "Polluted Delta", 2 },
                    { 13, "[\"black\",\"red\"]", "Bloodstained Mire", 2 },
                    { 14, "[\"red\",\"green\"]", "Wooded Foothills", 2 },
                    { 15, "[\"green\",\"white\"]", "Windswept Heath", 2 },
                    { 16, "[\"white\",\"black\"]", "Marsh Flats", 2 },
                    { 17, "[\"blue\",\"red\"]", "Scalding Tarn", 2 },
                    { 18, "[\"green\",\"blue\"]", "Misty Rainforest", 2 },
                    { 19, "[\"black\",\"green\"]", "Verdant Catacombs", 2 },
                    { 20, "[\"red\",\"white\"]", "Arid Mesa", 2 },
                    { 21, "[\"white\",\"blue\"]", "Hallowed Fountain", 3 },
                    { 22, "[\"blue\",\"black\"]", "Watery Grave", 3 },
                    { 23, "[\"black\",\"red\"]", "Blood Crypt", 3 },
                    { 24, "[\"red\",\"green\"]", "Stomping Ground", 3 },
                    { 25, "[\"green\",\"white\"]", "Temple Garden", 3 },
                    { 26, "[\"white\",\"black\"]", "Godless Shrine", 3 },
                    { 27, "[\"blue\",\"red\"]", "Steam Vents", 3 },
                    { 28, "[\"green\",\"blue\"]", "Breeding Pool", 3 },
                    { 29, "[\"black\",\"green\"]", "Overgrown Tomb", 3 },
                    { 30, "[\"red\",\"white\"]", "Sacred Foundry", 3 },
                    { 31, "[\"white\",\"blue\"]", "Sea of Clouds", 4 },
                    { 32, "[\"blue\",\"black\"]", "Morphic Pool", 4 },
                    { 33, "[\"black\",\"red\"]", "Luxury Suite", 4 },
                    { 34, "[\"red\",\"green\"]", "Spire Garden", 4 },
                    { 35, "[\"green\",\"white\"]", "Bountiful Promenade", 4 },
                    { 36, "[\"white\",\"black\"]", "Vault of Champions", 4 },
                    { 37, "[\"blue\",\"red\"]", "Training Center", 4 },
                    { 38, "[\"black\",\"green\"]", "Undergrowth Stadium", 4 },
                    { 39, "[\"red\",\"white\"]", "Spectator Seating", 4 },
                    { 40, "[\"green\",\"blue\"]", "Rejuvenating Spring", 4 },
                    { 41, "[\"white\",\"blue\",\"red\"]", "Raugrin Triome", 5 },
                    { 42, "[\"white\",\"black\",\"green\"]", "Indatha Triome", 5 },
                    { 43, "[\"blue\",\"red\",\"green\"]", "Ketria Triome", 5 },
                    { 44, "[\"red\",\"white\",\"black\"]", "Savai Triome", 5 },
                    { 45, "[\"black\",\"green\",\"blue\"]", "Zagoth Triome", 5 },
                    { 46, "[\"red\",\"green\",\"white\"]", "Jetmir's Garden", 5 },
                    { 47, "[\"green\",\"white\",\"blue\"]", "Spara's Headquarters", 5 },
                    { 48, "[\"blue\",\"black\",\"red\"]", "Xander's Lounge", 5 },
                    { 49, "[\"black\",\"red\",\"green\"]", "Ziatora's Proving Ground", 5 },
                    { 50, "[\"white\",\"blue\",\"black\"]", "Raffine's Tower", 5 },
                    { 51, "[\"white\",\"blue\"]", "Glacial Fortress", 6 },
                    { 52, "[\"blue\",\"black\"]", "Drowned Catacomb", 6 },
                    { 53, "[\"black\",\"red\"]", "Dragonskull Summit", 6 },
                    { 54, "[\"red\",\"green\"]", "Rootbound Crag", 6 },
                    { 55, "[\"green\",\"white\"]", "Sunpetal Grove", 6 },
                    { 56, "[\"white\",\"black\"]", "Isolated Chapel", 6 },
                    { 57, "[\"blue\",\"red\"]", "Sulfur Falls", 6 },
                    { 58, "[\"green\",\"blue\"]", "Hinterland Harbor", 6 },
                    { 59, "[\"black\",\"green\"]", "Woodland Cemetery", 6 },
                    { 60, "[\"red\",\"white\"]", "Clifftop Retreat", 6 },
                    { 61, "[\"white\",\"blue\"]", "Adarkar Wastes", 7 },
                    { 62, "[\"blue\",\"black\"]", "Underground River", 7 },
                    { 63, "[\"black\",\"red\"]", "Sulfurous Springs", 7 },
                    { 64, "[\"red\",\"green\"]", "Karplusan Forest", 7 },
                    { 65, "[\"green\",\"white\"]", "Brushland", 7 },
                    { 66, "[\"white\",\"black\"]", "Caves of Koilos", 7 },
                    { 67, "[\"blue\",\"red\"]", "Shivan Reef", 7 },
                    { 68, "[\"black\",\"green\"]", "Llanowar Wastes", 7 },
                    { 69, "[\"red\",\"white\"]", "Battlefield Forge", 7 },
                    { 70, "[\"green\",\"blue\"]", "Yavimaya Coast", 7 },
                    { 71, "[\"white\",\"blue\"]", "Seachrome Coast", 8 },
                    { 72, "[\"blue\",\"black\"]", "Darkslick Shores", 8 },
                    { 73, "[\"black\",\"red\"]", "Bloodfell Caves", 8 },
                    { 74, "[\"red\",\"white\"]", "Inspiring Vantage", 8 },
                    { 75, "[\"green\",\"blue\"]", "Botanical Sanctum", 8 },
                    { 76, "[\"red\",\"green\"]", "Cinder Glade", 8 },
                    { 77, "[\"white\",\"blue\"]", "Glacial Fortress", 8 },
                    { 78, "[\"green\",\"blue\"]", "Hinterland Harbor", 8 },
                    { 79, "[\"red\",\"white\"]", "Clifftop Retreat", 8 },
                    { 80, "[\"black\",\"green\"]", "Woodland Cemetery", 8 },
                    { 81, "[\"white\",\"blue\"]", "Hengegate Pathway", 9 },
                    { 82, "[\"blue\",\"black\"]", "Clearwater Pathway", 9 },
                    { 83, "[\"black\",\"red\"]", "Blightstep Pathway", 9 },
                    { 84, "[\"red\",\"white\"]", "Boulderloft Pathway", 9 },
                    { 85, "[\"green\",\"white\"]", "Branchloft Pathway", 9 },
                    { 86, "[\"red\",\"green\"]", "Grimclimb Pathway", 9 },
                    { 87, "[\"blue\",\"green\"]", "Riverglide Pathway", 9 },
                    { 88, "[\"black\",\"white\"]", "Shambling Vent", 9 },
                    { 89, "[\"black\",\"red\"]", "Sundown Pathway", 9 },
                    { 90, "[\"white\",\"green\"]", "Brightclimb Pathway", 9 },
                    { 91, "[\"white\",\"blue\"]", "Deserted Beach", 10 },
                    { 92, "[\"blue\",\"black\"]", "Dismal Backwater", 10 },
                    { 93, "[\"black\",\"red\"]", "Smoldering Marsh", 10 },
                    { 94, "[\"red\",\"green\"]", "Cinder Barrens", 10 },
                    { 95, "[\"green\",\"white\"]", "Tranquil Expanse", 10 },
                    { 96, "[\"white\",\"black\"]", "Forsaken Sanctuary", 10 },
                    { 97, "[\"blue\",\"red\"]", "Shivan Reef", 10 },
                    { 98, "[\"black\",\"green\"]", "Jungle Hollow", 10 },
                    { 99, "[\"red\",\"white\"]", "Clifftop Retreat", 10 },
                    { 100, "[\"green\",\"blue\"]", "Yavimaya Coast", 10 },
                    { 101, "[\"white\",\"blue\"]", "Mystic Gate", 11 },
                    { 102, "[\"blue\",\"black\"]", "Cascade Bluffs", 11 },
                    { 103, "[\"black\",\"red\"]", "Graven Cairns", 11 },
                    { 104, "[\"blue\",\"red\"]", "Sunken Ruins", 11 },
                    { 105, "[\"red\",\"green\"]", "Mystifying Maze", 11 },
                    { 106, "[\"black\",\"green\"]", "Twilight Mire", 11 },
                    { 107, "[\"white\",\"black\"]", "Sunken Ruins", 11 },
                    { 108, "[\"white\",\"green\"]", "Twilight Mire", 11 },
                    { 109, "[\"red\",\"white\"]", "Graven Cairns", 11 },
                    { 110, "[\"blue\",\"green\"]", "Mystifying Maze", 11 },
                    { 111, "[\"white\",\"blue\"]", "Temple of Enlightenment", 12 },
                    { 112, "[\"black\",\"red\"]", "Temple of Malice", 12 },
                    { 113, "[\"green\",\"blue\"]", "Temple of Mystery", 12 },
                    { 114, "[\"red\",\"white\"]", "Temple of Abandon", 12 },
                    { 115, "[\"white\",\"black\"]", "Temple of Silence", 12 },
                    { 116, "[\"red\",\"white\"]", "Temple of Triumph", 12 },
                    { 117, "[\"blue\",\"black\"]", "Temple of Deceit", 12 },
                    { 118, "[\"green\",\"white\"]", "Temple of Plenty", 12 },
                    { 119, "[\"blue\",\"red\"]", "Temple of Epiphany", 12 },
                    { 120, "[\"black\",\"green\"]", "Temple of Malady", 12 },
                    { 121, "[\"white\",\"blue\"]", "Tranquil Cove", 13 },
                    { 122, "[\"white\",\"black\"]", "Forsaken Sanctuary", 13 },
                    { 123, "[\"black\",\"red\"]", "Dragonskull Summit", 13 },
                    { 124, "[\"red\",\"white\"]", "Clifftop Retreat", 13 },
                    { 125, "[\"black\",\"green\"]", "Blooming Marsh", 13 },
                    { 126, "[\"white\",\"black\"]", "Scoured Barrens", 13 },
                    { 127, "[\"red\",\"white\"]", "Stone Quarry", 13 },
                    { 128, "[\"black\",\"green\"]", "Jungle Hollow", 13 },
                    { 129, "[\"white\",\"green\"]", "Sejiri Steppe", 13 },
                    { 130, "[\"black\",\"white\"]", "Shambling Vent", 13 },
                    { 131, "[\"white\",\"blue\"]", "Azorius Guildgate", 14 },
                    { 132, "[\"blue\",\"black\"]", "Dimir Guildgate", 14 },
                    { 133, "[\"black\",\"red\"]", "Rakdos Guildgate", 14 },
                    { 134, "[\"red\",\"green\"]", "Gruul Guildgate", 14 },
                    { 135, "[\"green\",\"white\"]", "Selesnya Guildgate", 14 },
                    { 136, "[\"white\",\"black\"]", "Orzhov Guildgate", 14 },
                    { 137, "[\"blue\",\"red\"]", "Izzet Guildgate", 14 },
                    { 138, "[\"black\",\"green\"]", "Golgari Guildgate", 14 },
                    { 139, "[\"red\",\"white\"]", "Boros Guildgate", 14 },
                    { 140, "[\"green\",\"blue\"]", "Simic Guildgate", 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LandTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Lands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Colors",
                value: "[\"blue\",\"white\"]");
        }
    }
}
