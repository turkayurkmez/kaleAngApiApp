using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTracker.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpectedFinishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualFinishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedRate = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Finans" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "İnsan Kaynakları" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ActualFinishedDate", "CategoryId", "CompletedRate", "Description", "ExpectedFinishedDate", "Name", "StartedDate" },
                values: new object[] { 1, null, 1, 0.0, "Kale grubu ve bankalar arası ödeme işlemleri", null, "Ödeme Sistemleri", new DateTime(2022, 7, 19, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ActualFinishedDate", "CategoryId", "CompletedRate", "Description", "ExpectedFinishedDate", "Name", "StartedDate" },
                values: new object[] { 2, null, 2, 0.0, "Kale grubu İK personeli yetkilendirme uygulaması", null, "HR Yetki Modülü", new DateTime(2022, 7, 19, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "ExpectedDate", "IsCompleted", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 1, "Db oluşturulacak", new DateTime(2022, 7, 26, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7538), false, "Veritabanı işlemleri", 1 },
                    { 2, ".NET Core ile API altyapısı...", new DateTime(2022, 8, 3, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7568), false, "API Yazılacak", 1 },
                    { 3, "Angular öğrenilecek", new DateTime(2022, 7, 26, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7571), false, "Angular Altyapısı", 2 },
                    { 4, "....", new DateTime(2022, 7, 22, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7576), false, "Güvenlik mekanizması", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CategoryId",
                table: "Projects",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
