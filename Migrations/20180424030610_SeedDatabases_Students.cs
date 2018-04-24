using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases_Students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            //10 Students
            migrationBuilder.Sql("INSERT INTO Students (Address, City, Country, FirstName, Grade, LastName, ParentId, School, State, ZipCode) VALUES ('XYZ St', 'Thousand Oaks', 'USA', 'StudentFN1', 1, 'StudentLN1', 1, 'Vista Elementary School', 'CA', '91360')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
