using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Magnajaya.Data.Migrations
{
    public partial class cbtrans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CbTransHs",
                columns: table => new
                {
                    CbTransHId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kode = table.Column<string>(maxLength: 2, nullable: true),
                    Docno = table.Column<string>(nullable: true),
                    NoPrj = table.Column<string>(nullable: true),
                    RefNo = table.Column<string>(nullable: true),
                    Keterangan = table.Column<string>(nullable: true),
                    Tanggal = table.Column<DateTime>(type: "date", nullable: false),
                    AcctSet = table.Column<string>(nullable: true),
                    Supplier = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true),
                    Giro = table.Column<string>(nullable: true),
                    TglGiro = table.Column<DateTime>(type: "date", nullable: false),
                    NamaGiro = table.Column<string>(nullable: true),
                    NamaCust = table.Column<string>(nullable: true),
                    TglCair = table.Column<DateTime>(type: "date", nullable: false),
                    TglGiro2 = table.Column<DateTime>(type: "date", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Debet = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Kredit = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Kurs = table.Column<string>(maxLength: 3, nullable: true),
                    KDebet = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    KKredit = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NonPPn = table.Column<bool>(nullable: false),
                    Cek = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CbTransHs", x => x.CbTransHId);
                });

            migrationBuilder.CreateTable(
                name: "CbTransDs",
                columns: table => new
                {
                    CbTransDId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kode = table.Column<string>(maxLength: 2, nullable: true),
                    NmBank = table.Column<string>(nullable: true),
                    DocNo = table.Column<string>(nullable: true),
                    RefNo = table.Column<string>(nullable: true),
                    NoPrj = table.Column<string>(nullable: true),
                    Tanggal = table.Column<DateTime>(type: "date", nullable: false),
                    Keterangan = table.Column<string>(nullable: true),
                    Tipe = table.Column<string>(nullable: true),
                    SrcCode = table.Column<string>(nullable: true),
                    NamaSrc = table.Column<string>(nullable: true),
                    GlAcct = table.Column<string>(nullable: true),
                    Jumlah = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Terima = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Bayar = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Kurs = table.Column<string>(nullable: true),
                    KValue = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    KJumlah = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    KTerima = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    KBayar = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AcctSet = table.Column<string>(nullable: true),
                    NonPPn = table.Column<bool>(nullable: false),
                    Cek = table.Column<string>(nullable: true),
                    CbTransHId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CbTransDs", x => x.CbTransDId);
                    table.ForeignKey(
                        name: "FK_CbTransDs_CbTransHs_CbTransHId",
                        column: x => x.CbTransHId,
                        principalTable: "CbTransHs",
                        principalColumn: "CbTransHId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CbTransDs_CbTransHId",
                table: "CbTransDs",
                column: "CbTransHId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CbTransDs");

            migrationBuilder.DropTable(
                name: "CbTransHs");
        }
    }
}
