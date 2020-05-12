using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearch.Migrations
{
    public partial class IsDeclined : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicantJob_Applicant_ApplicantId",
                table: "ApplicantJob");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "ApplicantJob",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeclined",
                table: "ApplicantJob",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abf7aede-e3da-484d-8503-d397cf64b15d", "AQAAAAEAACcQAAAAEASaorFE5TG2x+By8dDS9fPe44gFAutQzA54aqJrztH8LX3hbBU+6RYgqKab+jD0Cw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicantJob_Applicant_ApplicantId",
                table: "ApplicantJob",
                column: "ApplicantId",
                principalTable: "Applicant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicantJob_Applicant_ApplicantId",
                table: "ApplicantJob");

            migrationBuilder.DropColumn(
                name: "IsDeclined",
                table: "ApplicantJob");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "ApplicantJob",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e66dfbc3-8894-454f-85b7-aa2570497b11", "AQAAAAEAACcQAAAAEJyAT6GApCb87kOzU/b/Z0WoU+FWqPt1QtqZJ/QmK/GwJEJsGPPwt2GIAK1f/17tZA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicantJob_Applicant_ApplicantId",
                table: "ApplicantJob",
                column: "ApplicantId",
                principalTable: "Applicant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
