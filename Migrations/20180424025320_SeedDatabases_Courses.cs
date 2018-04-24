using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases_Courses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //6 Courses
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (1, 'Scratch', 14)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (1, 'Kodu', 14)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (2, 'Game Maker Studio', 14)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (3, 'Unity', 3)");

            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (1, 'Lego Wedo', 12)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (2, 'mBot', 12)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (3, 'eV3', 12)");

            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (1, 'Snap Circuits', 13)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (3, 'Computer assembly', 13)");

            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (2, 'Greenfoot Java', 15)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (3, 'Python Programming', 15)");

            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (1, 'Digital Art', 16)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (1, 'Mudbox', 16)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (1, 'Maya', 16)");

            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (0, 'Arithmetic-I',18 )");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (0, 'Geometry-I', 19)");
            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (0, 'Calculus-I', 20)");

            migrationBuilder.Sql("INSERT INTO Courses (Level, Name, SubCategoryId) VALUES (0, 'Alpha', 21)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
