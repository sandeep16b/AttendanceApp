using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases_Parents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            //9 Parents
            migrationBuilder.Sql("INSERT INTO Parents (Email, FirstName, LastName, Phone) VALUES ('snowydrizzle16@gmail.com', 'ParentFN1', 'ParentLN1', '9898540000')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
