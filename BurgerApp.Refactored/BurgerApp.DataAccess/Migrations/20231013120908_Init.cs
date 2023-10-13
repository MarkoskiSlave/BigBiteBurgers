using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerApp.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Burgers",
                schema: "dbo",
                columns: table => new
                {
                    BurgerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    RoadToImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgers", x => x.BurgerId);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                schema: "dbo",
                columns: table => new
                {
                    DrinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RoadToImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.DrinkId);
                });

            migrationBuilder.CreateTable(
                name: "Fries",
                schema: "dbo",
                columns: table => new
                {
                    FriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    RoadToImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fries", x => x.FriesId);
                });

            migrationBuilder.CreateTable(
                name: "BestCombos",
                schema: "dbo",
                columns: table => new
                {
                    BestComboId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurgerId = table.Column<int>(type: "int", nullable: false),
                    FriesId = table.Column<int>(type: "int", nullable: false),
                    DrinkId = table.Column<int>(type: "int", nullable: false),
                    BestComboName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RoadToImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestCombos", x => x.BestComboId);
                    table.ForeignKey(
                        name: "FK_BestCombos_Burgers_BurgerId",
                        column: x => x.BurgerId,
                        principalSchema: "dbo",
                        principalTable: "Burgers",
                        principalColumn: "BurgerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BestCombos_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalSchema: "dbo",
                        principalTable: "Drinks",
                        principalColumn: "DrinkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BestCombos_Fries_FriesId",
                        column: x => x.FriesId,
                        principalSchema: "dbo",
                        principalTable: "Fries",
                        principalColumn: "FriesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Burgers",
                columns: new[] { "BurgerId", "Calories", "Description", "Name", "Price", "RoadToImage" },
                values: new object[,]
                {
                    { 1, 600, "A juicy 100% Angus beef patty topped with fresh lettuce, ripe tomatoes, sliced red onions, and a special house-made burger sauce, all served on a toasted sesame seed bun.", "Classic Beef Burger", 10.0, "~/Images/Burgers/ClassicBurger.png" },
                    { 2, 450, "A mouthwatering veggie patty made from black beans, chickpeas, and quinoa, topped with avocado slices, grilled zucchini, roasted bell peppers, and a tangy garlic aioli, served on a whole wheat bun.", "Veggie Burger", 8.5, "~/Images/Burgers/VeggieBurger.png" },
                    { 3, 720, "Crispy chicken breast tossed in spicy Sriracha sauce, topped with pepper jack cheese, pickled jalapenos, coleslaw, tomato, and a drizzle of Sriracha mayo, served on a sesame seed bun.", "Spicy Sriracha Chicken Burger", 11.5, "~/Images/Burgers/Chicken.png" },
                    { 4, 550, "Grilled chicken breast topped with creamy avocado slices, mixed greens, red pepper flakes, and a zesty lime aioli, served on a ciabatta roll.", "Chicken Avocado Burger", 9.5, "~/Images/Burgers/AvocadoChicken.png" },
                    { 5, 800, "A breakfast delight with a beef patty, fried egg, crispy bacon, American cheese, and maple aioli, all served on a buttery brioche bun.", "Breakfast Burger", 10.5, "~/Images/Burgers/BreakfastBurger.png" },
                    { 6, 550, "A plant-based Beyond Meat patty topped with vegan cheese, lettuce, tomato, red onion, and a vegan mayo-based sauce, served on a gluten-free bun.", "Beyond Burger", 9.3000000000000007, "~/Images/Burgers/BeyondBurger.png" },
                    { 7, 600, "A timeless favorite! Our juicy beef patty topped with cheddar cheese, fresh lettuce, ripe tomatoes, onions, pickles, and our secret special sauce, all nestled in a soft sesame seed bun.", "Classic Cheeseburger", 9.0, "~/Images/Burgers/ClassicCheeseburger.png" },
                    { 8, 680, "For the cheese aficionados! This mouthwatering burger comes with a juicy beef patty, rich and tangy blue cheese crumbles, caramelized onions, and arugula on a toasted ciabatta bun.", "Blue Cheese Burger", 10.800000000000001, "~/Images/Burgers/BlueCheeseBurger.png" },
                    { 9, 680, "A fiery beef patty topped with pepper jack cheese, pickled jalapenos, lettuce, and chipotle mayo, served on a jalapeno-cheddar bun.", "Spicy Jalapeno Burger", 9.1999999999999993, "~/Images/Burgers/JalapeñoBurger.png" },
                    { 10, 800, "Juicy 100% Angus beef, topped with our secret smoky spices, melted cheddar cheese, bacon and fresh lettuce and chunky BBQ sauce, all served in our signature bun.", "Big Bite Burger", 12.5, "~/Images/Burgers/BigBiteBurger.png" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Drinks",
                columns: new[] { "DrinkId", "Calories", "Name", "Price", "RoadToImage", "Size" },
                values: new object[,]
                {
                    { 1, 140, "Coca Cola", 2.0, "~/Images/Drinks/CocaCola.png", "0.33" },
                    { 2, 150, "Pepsi", 2.0, "~/Images/Drinks/Pepsi.png", "0.33" },
                    { 3, 120, "Fanta", 2.0, "~/Images/Drinks/Fanta.png", "0.33" },
                    { 4, 110, "Orange Juice", 2.0, "~/Images/Drinks/OrangeJuice.png", "0.33" },
                    { 5, 90, "Ice Tea", 2.0, "~/Images/Drinks/Lipton.png", "0.33" },
                    { 6, 80, "Rosa", 2.0, "~/Images/Drinks/Rosa.png", "0.33" },
                    { 7, 70, "Heineken", 2.0, "~/Images/Drinks/Heineken.png", "0.33" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Fries",
                columns: new[] { "FriesId", "Calories", "Price", "RoadToImage", "Size" },
                values: new object[,]
                {
                    { 1, 150, 3.0, "~/Images/Fries/SmallFries.png", "Small" },
                    { 2, 250, 6.0, "~/Images/Fries/MediumFries.png", "Medium" },
                    { 3, 350, 9.0, "~/Images/Fries/LargeFries.png", "Large" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BestCombos_BurgerId",
                schema: "dbo",
                table: "BestCombos",
                column: "BurgerId");

            migrationBuilder.CreateIndex(
                name: "IX_BestCombos_DrinkId",
                schema: "dbo",
                table: "BestCombos",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_BestCombos_FriesId",
                schema: "dbo",
                table: "BestCombos",
                column: "FriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BestCombos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Burgers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Drinks",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Fries",
                schema: "dbo");
        }
    }
}
