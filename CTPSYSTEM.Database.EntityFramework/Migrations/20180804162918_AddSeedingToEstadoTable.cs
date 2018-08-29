using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Database.EntityFramework.Migrations
{
    public partial class AddSeedingToEstadoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sigla",
                table: "Estado",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 2);

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "Nome", "Sigla" },
                values: new object[,]
                {
                    { 1, "Acre", 1 },
                    { 25, "Sergipe", 26 },
                    { 24, "Santa Catarina", 24 },
                    { 23, "Rio Grande do Sul", 23 },
                    { 22, "Roraima", 19 },
                    { 21, "Rondônia", 20 },
                    { 20, "Rio Grande do Norte", 22 },
                    { 19, "Rio de Janeiro", 21 },
                    { 18, "Paraná", 16 },
                    { 17, "Piauí", 18 },
                    { 16, "Pernambuco", 17 },
                    { 15, "Paraíba", 15 },
                    { 26, "São Paulo", 25 },
                    { 14, "Pará", 14 },
                    { 12, "Mato Grosso do Sul", 12 },
                    { 11, "Minas Gerais", 13 },
                    { 10, "Maranhão", 10 },
                    { 9, "Goiás", 9 },
                    { 8, "Espírito Santo", 8 },
                    { 7, "Distrito Federal", 7 },
                    { 6, "Ceará", 6 },
                    { 5, "Bahia", 5 },
                    { 4, "Amapá", 3 },
                    { 3, "Amazonas", 4 },
                    { 2, "Alagoas", 2 },
                    { 13, "Mato Grosso", 11 },
                    { 27, "Tocantins", 27 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.AlterColumn<string>(
                name: "Sigla",
                table: "Estado",
                type: "VARCHAR",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}