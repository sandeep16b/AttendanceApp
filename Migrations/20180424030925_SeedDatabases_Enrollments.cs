using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedDatabases_Enrollments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //12 Enrollments
            migrationBuilder.Sql("INSERT INTO Enrollments (EnrolledDateTime, ClassID, StudentID, EnrollmentDurationId) VALUES ('4/17/2018 2:22 PM', 5, 1, 1)");
            


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
