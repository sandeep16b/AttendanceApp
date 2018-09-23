using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class SeedPaymenttoEnrollTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("UPDATE Enrollments SET Payment = 'Paid'  WHERE Id = 2  ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
