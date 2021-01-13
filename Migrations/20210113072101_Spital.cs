using Microsoft.EntityFrameworkCore.Migrations;

namespace Pop_Simona_Proiect1.Migrations
{
    public partial class Spital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PretConsult",
                table: "ProgramareMedic",
                type: "decimal(6, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "SpitalID",
                table: "ProgramareMedic",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Spital",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeSpital = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spital", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramareMedic_SpitalID",
                table: "ProgramareMedic",
                column: "SpitalID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramareMedic_Spital_SpitalID",
                table: "ProgramareMedic",
                column: "SpitalID",
                principalTable: "Spital",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramareMedic_Spital_SpitalID",
                table: "ProgramareMedic");

            migrationBuilder.DropTable(
                name: "Spital");

            migrationBuilder.DropIndex(
                name: "IX_ProgramareMedic_SpitalID",
                table: "ProgramareMedic");

            migrationBuilder.DropColumn(
                name: "SpitalID",
                table: "ProgramareMedic");

            migrationBuilder.AlterColumn<decimal>(
                name: "PretConsult",
                table: "ProgramareMedic",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 2)");
        }
    }
}
