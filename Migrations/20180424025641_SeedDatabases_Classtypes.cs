using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases_Classtypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            //7 ClassTypes
            migrationBuilder.Sql("INSERT INTO ClassTypes (Name) VALUES ('Studio')");
            migrationBuilder.Sql("INSERT INTO ClassTypes (Name) VALUES ('School')");
            migrationBuilder.Sql("INSERT INTO ClassTypes (Name) VALUES ('Community Center')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
