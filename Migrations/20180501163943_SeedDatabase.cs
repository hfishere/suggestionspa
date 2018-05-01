using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace suggestionspa.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genders",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);
            
            migrationBuilder.Sql("INSERT INTO Genders (Name) VALUES ('Man')");
            migrationBuilder.Sql("INSERT INTO Genders (Name) VALUES ('Woman')");

            migrationBuilder.Sql("INSERT INTO Employees (Name, GenderId) VALUES ('Hafidz', (SELECT Id FROM Genders WHERE Name='Man'))");
            migrationBuilder.Sql("INSERT INTO Employees (Name, GenderId) VALUES ('Fairiz', (SELECT Id FROM Genders WHERE Name='Man'))");
            migrationBuilder.Sql("INSERT INTO Employees (Name, GenderId) VALUES ('Zaid', (SELECT Id FROM Genders WHERE Name='Man'))");

            migrationBuilder.Sql("INSERT INTO Employees (Name, GenderId) VALUES ('Ahsani', (SELECT Id FROM Genders WHERE Name='Woman'))");
            migrationBuilder.Sql("INSERT INTO Employees (Name, GenderId) VALUES ('Ashri', (SELECT Id FROM Genders WHERE Name='Woman'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genders",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.Sql("DELETE FROM Genders");
            migrationBuilder.Sql("DELETE FROM Employees");            
        }
    }
}
