using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases_SubCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //5 SubCategories
            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (13, 'Robotics')");
            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (13, 'Electronics')");
            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (14, 'Game Design')");
            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (14, 'Programming')");
            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (15, 'Multimedia')");
            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (15, 'Web Design')");

            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (16, 'Math-Elementary')");
            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (16, 'Math-Middle')");
            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (16, 'Math-High')");
            migrationBuilder.Sql("INSERT INTO SubCategories (CategoryId, Name) VALUES (17, 'Noetic')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
