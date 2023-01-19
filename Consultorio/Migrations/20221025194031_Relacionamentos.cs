using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class Relacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_especialidade_EspecialidadeId",
                table: "tb_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_profissional_ProfissionalId",
                table: "tb_consulta");

            migrationBuilder.RenameColumn(
                name: "ProfissionalId",
                table: "tb_consulta",
                newName: "id_profissional");

            migrationBuilder.RenameColumn(
                name: "EspecialidadeId",
                table: "tb_consulta",
                newName: "id_especialidade");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_ProfissionalId",
                table: "tb_consulta",
                newName: "IX_tb_consulta_id_profissional");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_EspecialidadeId",
                table: "tb_consulta",
                newName: "IX_tb_consulta_id_especialidade");

            migrationBuilder.CreateTable(
                name: "EspecialidadeProfissional",
                columns: table => new
                {
                    EspecialidadesId = table.Column<int>(type: "int", nullable: false),
                    ProfissionaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadeProfissional", x => new { x.EspecialidadesId, x.ProfissionaisId });
                    table.ForeignKey(
                        name: "FK_EspecialidadeProfissional_tb_especialidade_EspecialidadesId",
                        column: x => x.EspecialidadesId,
                        principalTable: "tb_especialidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadeProfissional_tb_profissional_ProfissionaisId",
                        column: x => x.ProfissionaisId,
                        principalTable: "tb_profissional",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadeProfissional_ProfissionaisId",
                table: "EspecialidadeProfissional",
                column: "ProfissionaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_especialidade_id_especialidade",
                table: "tb_consulta",
                column: "id_especialidade",
                principalTable: "tb_especialidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_profissional_id_profissional",
                table: "tb_consulta",
                column: "id_profissional",
                principalTable: "tb_profissional",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_especialidade_id_especialidade",
                table: "tb_consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_consulta_tb_profissional_id_profissional",
                table: "tb_consulta");

            migrationBuilder.DropTable(
                name: "EspecialidadeProfissional");

            migrationBuilder.RenameColumn(
                name: "id_profissional",
                table: "tb_consulta",
                newName: "ProfissionalId");

            migrationBuilder.RenameColumn(
                name: "id_especialidade",
                table: "tb_consulta",
                newName: "EspecialidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_id_profissional",
                table: "tb_consulta",
                newName: "IX_tb_consulta_ProfissionalId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_consulta_id_especialidade",
                table: "tb_consulta",
                newName: "IX_tb_consulta_EspecialidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_especialidade_EspecialidadeId",
                table: "tb_consulta",
                column: "EspecialidadeId",
                principalTable: "tb_especialidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_consulta_tb_profissional_ProfissionalId",
                table: "tb_consulta",
                column: "ProfissionalId",
                principalTable: "tb_profissional",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
