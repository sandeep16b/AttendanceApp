using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class ChangedEnrollmentDurationsTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Classes_ClassID",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_EnrollmentDuration_EnrollmentDurationId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnrollmentDuration",
                table: "EnrollmentDuration");

            migrationBuilder.RenameTable(
                name: "EnrollmentDuration",
                newName: "EnrollmentDurations");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Enrollments",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "Enrollments",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_StudentID",
                table: "Enrollments",
                newName: "IX_Enrollments_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_ClassID",
                table: "Enrollments",
                newName: "IX_Enrollments_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnrollmentDurations",
                table: "EnrollmentDurations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Classes_ClassId",
                table: "Enrollments",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_EnrollmentDurations_EnrollmentDurationId",
                table: "Enrollments",
                column: "EnrollmentDurationId",
                principalTable: "EnrollmentDurations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Classes_ClassId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_EnrollmentDurations_EnrollmentDurationId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnrollmentDurations",
                table: "EnrollmentDurations");

            migrationBuilder.RenameTable(
                name: "EnrollmentDurations",
                newName: "EnrollmentDuration");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Enrollments",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Enrollments",
                newName: "ClassID");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                newName: "IX_Enrollments_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_ClassId",
                table: "Enrollments",
                newName: "IX_Enrollments_ClassID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnrollmentDuration",
                table: "EnrollmentDuration",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Classes_ClassID",
                table: "Enrollments",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_EnrollmentDuration_EnrollmentDurationId",
                table: "Enrollments",
                column: "EnrollmentDurationId",
                principalTable: "EnrollmentDuration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
