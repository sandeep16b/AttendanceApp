using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            //4 Categories
            migrationBuilder.Sql("INSERT INTO Categories (Name, SubjectId) VALUES ('Hardware', 5)");
            migrationBuilder.Sql("INSERT INTO Categories (Name, SubjectId) VALUES ('Software', 5)");
            migrationBuilder.Sql("INSERT INTO Categories (Name, SubjectId) VALUES ('Design', 5)");
            migrationBuilder.Sql("INSERT INTO Categories (Name, SubjectId) VALUES ('Tutoring', 6)");
            migrationBuilder.Sql("INSERT INTO Categories (Name, SubjectId) VALUES ('Competitions', 6)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnrolledDateTime",
                table: "Enrollments",
                newName: "DateTime");
        }
    }
}
