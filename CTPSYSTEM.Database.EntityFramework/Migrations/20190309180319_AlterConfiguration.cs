using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class AlterConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataSaida",
                table: "ContratoTrabalho",
                nullable: true,
                oldClrType: typeof(DateTimeOffset));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataSaida",
                table: "ContratoTrabalho",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);
        }
    }
}
