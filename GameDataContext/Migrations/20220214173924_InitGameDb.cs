﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameDataContext.Migrations
{
    public partial class InitGameDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfGame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ganre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Realese = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GameMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoldItemsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
