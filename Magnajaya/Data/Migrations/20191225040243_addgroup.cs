using Microsoft.EntityFrameworkCore.Migrations;

namespace Magnajaya.Data.Migrations
{
    public partial class addgroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CbGrp",
                columns: table => new
                {
                    CbGrpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grp = table.Column<string>(nullable: true),
                    NamaGrp = table.Column<string>(nullable: true),
                    GrpNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CbGrp", x => x.CbGrpId);
                });

            migrationBuilder.CreateTable(
                name: "Srccode",
                columns: table => new
                {
                    CbSrccdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SrcCode = table.Column<string>(nullable: true),
                    NamaSrc = table.Column<string>(nullable: true),
                    GlAcct = table.Column<string>(nullable: true),
                    Grp = table.Column<string>(nullable: true),
                    CbGrpId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Srccode", x => x.CbSrccdId);
                    table.ForeignKey(
                        name: "FK_Srccode_CbGrp_CbGrpId",
                        column: x => x.CbGrpId,
                        principalTable: "CbGrp",
                        principalColumn: "CbGrpId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Srccode_CbGrpId",
                table: "Srccode",
                column: "CbGrpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Srccode");

            migrationBuilder.DropTable(
                name: "CbGrp");
        }
    }
}
