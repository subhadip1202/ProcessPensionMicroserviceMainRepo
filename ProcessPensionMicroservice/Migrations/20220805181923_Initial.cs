using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessPensionMicroservice.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pensionDetails",
                columns: table => new
                {
                    aadharno = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PensionAmount = table.Column<long>(nullable: false),
                    BankServiceCharge = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pensionDetails", x => x.aadharno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pensionDetails");
        }
    }
}
