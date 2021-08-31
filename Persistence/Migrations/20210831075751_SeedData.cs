using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("ba2dd387-db75-4be9-8cb0-9b51c279d802"), "Channel dedicated to development in ASP.NET Core 5", "DotNetCore" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("ac7fc5b7-3b6b-46a4-9ea2-cf1ed8337cbc"), "Channel dedicated to development in Angular", "Angular" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("800092b8-91bf-4df0-ab48-df89d741b154"), "Channel dedicated to development in React.js", "React.js" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("800092b8-91bf-4df0-ab48-df89d741b154"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("ac7fc5b7-3b6b-46a4-9ea2-cf1ed8337cbc"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("ba2dd387-db75-4be9-8cb0-9b51c279d802"));
        }
    }
}
