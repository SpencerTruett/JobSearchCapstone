using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearch.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "047a81d4-f5b7-4747-9a9e-74a247f44bb6", "AQAAAAEAACcQAAAAEMgFr98ecOqHKcNzT+CHSe8y0wpP0rcyfErHfC3gTScTMqzCRkOne1lUmujsMKt/kw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9443fe1-168d-406e-a359-13e8849da6e9", "AQAAAAEAACcQAAAAEKjoT6JYGncvqIC4tp6v7MdgezOPBWlw/YRaChUoXINg6/0cDNKjo+u9fnJItOyyGg==" });
        }
    }
}
