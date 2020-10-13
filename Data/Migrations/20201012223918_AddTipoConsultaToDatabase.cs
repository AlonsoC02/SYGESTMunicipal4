using Microsoft.EntityFrameworkCore.Migrations;

namespace SYGESTMunicipal.Data.Migrations
{
    public partial class AddTipoConsultaToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoConsulta",
                columns: table => new
                {
                    TipoConsultaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoConsulta = table.Column<string>(nullable: true),
                    RedLocal = table.Column<bool>(nullable: false),
                    PersonaOFIMId = table.Column<string>(nullable: true),
                    ConsultaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoConsulta", x => x.TipoConsultaId);
                    table.ForeignKey(
                        name: "FK_TipoConsulta_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consulta",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipoConsulta_PersonaOFIM_PersonaOFIMId",
                        column: x => x.PersonaOFIMId,
                        principalTable: "PersonaOFIM",
                        principalColumn: "PersonaOFIMId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoConsulta_ConsultaId",
                table: "TipoConsulta",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoConsulta_PersonaOFIMId",
                table: "TipoConsulta",
                column: "PersonaOFIMId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoConsulta");
        }
    }
}
