using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class AddEnrollmentDuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnrollmentDurationId",
                table: "Enrollments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EnrollmentDuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrollmentDuration", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_EnrollmentDurationId",
                table: "Enrollments",
                column: "EnrollmentDurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_EnrollmentDuration_EnrollmentDurationId",
                table: "Enrollments",
                column: "EnrollmentDurationId",
                principalTable: "EnrollmentDuration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_EnrollmentDuration_EnrollmentDurationId",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "EnrollmentDuration");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_EnrollmentDurationId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "EnrollmentDurationId",
                table: "Enrollments");
        }
    }
}
