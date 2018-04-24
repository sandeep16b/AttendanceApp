using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EnrolledDateTime",
                table: "Enrollments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));


            //1 Divisions
            migrationBuilder.Sql("INSERT INTO Divisions (Name) VALUES ('Div001')");
            migrationBuilder.Sql("INSERT INTO Divisions (Name) VALUES ('Div002')");
            migrationBuilder.Sql("INSERT INTO Divisions (Name) VALUES ('Div003')");

            //2 Locations
            migrationBuilder.Sql("INSERT INTO Locations (City, DivisionID ,Name, Type) VALUES ('Thousand Oaks', (SELECT ID FROM Divisions WHERE Name='Div001'), 'Sandbox', 'Studio')");
            migrationBuilder.Sql("INSERT INTO Locations (City, DivisionID ,Name, Type) VALUES ('Thousand Oaks', (SELECT ID FROM Divisions WHERE Name='Div001'), 'Lang Ranch Elementary', 'School')");
            migrationBuilder.Sql("INSERT INTO Locations (City, DivisionID ,Name, Type) VALUES ('Oak Park', (SELECT ID FROM Divisions WHERE Name='Div001'), 'Oak Park CC', 'Community Center')");

            migrationBuilder.Sql("INSERT INTO Locations (City, DivisionID ,Name, Type) VALUES ('Mount Pleasant', (SELECT ID FROM Divisions WHERE Name='Div002'), 'Sandbox', 'Studio')");
            migrationBuilder.Sql("INSERT INTO Locations (City, DivisionID ,Name, Type) VALUES ('Mount Pleasant', (SELECT ID FROM Divisions WHERE Name='Div002'), 'Mount Pleasant Elementary', 'School')");
            migrationBuilder.Sql("INSERT INTO Locations (City, DivisionID ,Name, Type) VALUES ('Lansing', (SELECT ID FROM Divisions WHERE Name='Div002'), 'Lansing CC', 'Community Center')");

            migrationBuilder.Sql("INSERT INTO Locations (City, DivisionID ,Name, Type) VALUES ('Omaha', (SELECT ID FROM Divisions WHERE Name='Div003'), 'Sandbox', 'Studio')");
            migrationBuilder.Sql("INSERT INTO Locations (City, DivisionID ,Name, Type) VALUES ('Omaha', (SELECT ID FROM Divisions WHERE Name='Div003'), 'Omaha Elementary', 'School')");
            migrationBuilder.Sql("INSERT INTO Locations (City, DivisionID ,Name, Type) VALUES ('Omaha', (SELECT ID FROM Divisions WHERE Name='Div003'), 'Omaha CC', 'Community Center')");
       


            //3 Subjects
            migrationBuilder.Sql("INSERT INTO Subjects (Name) VALUES ('Computers')");
            migrationBuilder.Sql("INSERT INTO Subjects (Name) VALUES ('Math')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Enrollments");
        }
    }
}
