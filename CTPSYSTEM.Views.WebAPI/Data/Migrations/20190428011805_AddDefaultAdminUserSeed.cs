using Microsoft.EntityFrameworkCore.Migrations;

namespace CTPSYSTEM.Views.WebAPI.Data.Migrations
{
    public partial class AddDefaultAdminUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0327e850-74fc-4df7-b48f-2ec1ac567f0a", "1ed8fe52-beea-4e84-a4d6-bd9d99a7d475" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "03cfb915-714e-402a-b59e-4ba329e462b2", "d01a7e4b-a796-45e7-962f-b17845c2b307" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a9ae05cd-7e33-4521-8835-7dd109d35909", "c0e8d976-385a-4988-9e97-64f1d326ebcb" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9247e5be-2f35-44a5-9dca-3d1af8be4bae", "42587144-8b53-49c7-ac31-b0292f55a6db", "funcionario", "FUNCIONARIO" },
                    { "1cb0f3ed-5f8e-4a17-8ef6-e38ece9e45e8", "db698593-9c36-444e-82c2-5ffd4f0e7f9d", "usuario", "USUARIO" },
                    { "10b63dc2-39e7-40eb-bce9-cedc75b4d444", "cc6ba509-fe95-4d85-a57e-f43f0620070c", "empresa", "EMPRESA" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6b68b57f-c929-4b7f-87f1-226b0f8f8dd1", 0, "75127fd5-37c1-4d66-b6db-4c3049eb3467", "mayconklopper@gov.br", false, true, null, "MAYCONKLOPPER@GOV.BR", "MAYCONKLOPPER", "AQAAAAEAACcQAAAAEPCL84na88p5ZdF389fAXzO8CNWwwsZ9+DL3Mdb635TYGhjf7imRwL++fd9cBbLZhA==", "21970298364", false, "d0823930-e4b2-4212-b141-4636779243d3", false, "mayconklopper" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "6b68b57f-c929-4b7f-87f1-226b0f8f8dd1", "9247e5be-2f35-44a5-9dca-3d1af8be4bae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "10b63dc2-39e7-40eb-bce9-cedc75b4d444", "cc6ba509-fe95-4d85-a57e-f43f0620070c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1cb0f3ed-5f8e-4a17-8ef6-e38ece9e45e8", "db698593-9c36-444e-82c2-5ffd4f0e7f9d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6b68b57f-c929-4b7f-87f1-226b0f8f8dd1", "9247e5be-2f35-44a5-9dca-3d1af8be4bae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9247e5be-2f35-44a5-9dca-3d1af8be4bae", "42587144-8b53-49c7-ac31-b0292f55a6db" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6b68b57f-c929-4b7f-87f1-226b0f8f8dd1", "75127fd5-37c1-4d66-b6db-4c3049eb3467" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0327e850-74fc-4df7-b48f-2ec1ac567f0a", "1ed8fe52-beea-4e84-a4d6-bd9d99a7d475", "funcionario", "FUNCIONARIO" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9ae05cd-7e33-4521-8835-7dd109d35909", "c0e8d976-385a-4988-9e97-64f1d326ebcb", "usuario", "USUARIO" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03cfb915-714e-402a-b59e-4ba329e462b2", "d01a7e4b-a796-45e7-962f-b17845c2b307", "empresa", "EMPRESA" });
        }
    }
}
