using Microsoft.EntityFrameworkCore.Migrations;

namespace Pop_Simona_Proiect1.Migrations
{
    public partial class Consultatie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConsultatieID",
                table: "ProgramareMedic",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Consultatie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipConsultatie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultatie", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramareMedic_ConsultatieID",
                table: "ProgramareMedic",
                column: "ConsultatieID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramareMedic_Consultatie_ConsultatieID",
                table: "ProgramareMedic",
                column: "ConsultatieID",
                principalTable: "Consultatie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramareMedic_Consultatie_ConsultatieID",
                table: "ProgramareMedic");

            migrationBuilder.DropTable(
                name: "Consultatie");

            migrationBuilder.DropIndex(
                name: "IX_ProgramareMedic_ConsultatieID",
                table: "ProgramareMedic");

            migrationBuilder.DropColumn(
                name: "ConsultatieID",
                table: "ProgramareMedic");
        }
    }
}
