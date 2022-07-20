using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTracker.DataAccess.Migrations
{
    public partial class add_users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 11, 15, 27, 717, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 7, 20, 11, 15, 27, 717, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpectedDate",
                value: new DateTime(2022, 7, 27, 11, 15, 27, 717, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpectedDate",
                value: new DateTime(2022, 8, 4, 11, 15, 27, 717, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpectedDate",
                value: new DateTime(2022, 7, 27, 11, 15, 27, 717, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpectedDate",
                value: new DateTime(2022, 7, 23, 11, 15, 27, 717, DateTimeKind.Local).AddTicks(5655));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 7, 19, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 7, 19, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpectedDate",
                value: new DateTime(2022, 7, 26, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpectedDate",
                value: new DateTime(2022, 8, 3, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpectedDate",
                value: new DateTime(2022, 7, 26, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpectedDate",
                value: new DateTime(2022, 7, 22, 16, 16, 4, 193, DateTimeKind.Local).AddTicks(7576));
        }
    }
}
