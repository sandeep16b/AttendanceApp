using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases_EnrollmentDuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //11 EnrollmentDuration
            migrationBuilder.Sql("INSERT INTO EnrollmentDuration (Name) VALUES ('Full')");
            migrationBuilder.Sql("INSERT INTO EnrollmentDuration (Name) VALUES ('Partial')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
