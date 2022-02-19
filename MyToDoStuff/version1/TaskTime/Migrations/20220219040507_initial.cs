using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTime.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    AppResponseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DueDate = table.Column<string>(nullable: true),
                    EstimateTime = table.Column<int>(nullable: false),
                    TimeSpent = table.Column<int>(nullable: false),
                    TimeLeft = table.Column<int>(nullable: false),
                    Update = table.Column<string>(nullable: true),
                    LastUpdated = table.Column<string>(nullable: true),
                    Quadrant = table.Column<string>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.AppResponseId);
                    table.ForeignKey(
                        name: "FK_Responses_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "AppResponseId", "CategoryID", "Completed", "Description", "DueDate", "EstimateTime", "LastUpdated", "Quadrant", "Task", "TimeLeft", "TimeSpent", "Update" },
                values: new object[] { 1, 1, false, null, "Feb 8th", 0, null, "Quadrant III", "Eat Breakfast", 0, 0, null });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "AppResponseId", "CategoryID", "Completed", "Description", "DueDate", "EstimateTime", "LastUpdated", "Quadrant", "Task", "TimeLeft", "TimeSpent", "Update" },
                values: new object[] { 2, 2, false, null, "Feb 8th", 0, null, "Quadrant III", "Make bed", 0, 0, null });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryID",
                table: "Responses",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
