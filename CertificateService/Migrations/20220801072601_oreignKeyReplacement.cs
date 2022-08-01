using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertificateService.Migrations
{
    public partial class oreignKeyReplacement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Patients_ID",
                table: "Certificates");

            migrationBuilder.AddColumn<Guid>(
                name: "PatientID",
                table: "Certificates",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_PatientID",
                table: "Certificates",
                column: "PatientID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Patients_PatientID",
                table: "Certificates",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Patients_PatientID",
                table: "Certificates");

            migrationBuilder.DropIndex(
                name: "IX_Certificates_PatientID",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Certificates");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Patients_ID",
                table: "Certificates",
                column: "ID",
                principalTable: "Patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
