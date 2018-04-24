using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases_Classes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //8 Classes
            migrationBuilder.Sql("INSERT INTO Classes (ClassTypeId, CourseId, EndDate, EndTime, Frequency, Holidays, LocationId, NoOfOccurences, StartDate, StartTime) VALUES (4, 19, '05-04-2018', '4:00 PM', 'Daily', 0, 19, 5, '04-30-2018', '1:00 PM')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
