using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netCore_todoAPI_ef.Migrations
{
    public partial class ver000alpha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "todoItem",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_todoItem", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "todoItem");
        }
    }
}
