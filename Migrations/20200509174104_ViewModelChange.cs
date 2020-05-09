using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearch.Migrations
{
    public partial class ViewModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43f7561c-6fef-4404-987a-2eb917db19f8", "AQAAAAEAACcQAAAAECdWg2/8B8dn11Om8aqGcfHHo8TR4h0QYs3AJkSNNdXTSaOM5Glfge/JAvxKntRivw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d73ec90-d470-450c-a42c-23197d898fd7", "AQAAAAEAACcQAAAAEIUqe8Bv7SyWo+CbqArit8VCc+IZvlQ1mSrVh8bbwWqPeYMF+vzizwteHvZI8fAW8A==" });
        }
    }
}
