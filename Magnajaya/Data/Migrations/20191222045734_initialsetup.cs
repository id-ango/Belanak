using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Magnajaya.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    CbBankId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kode = table.Column<string>(maxLength: 2, nullable: true),
                    NmBank = table.Column<string>(nullable: true),
                    SldAwal = table.Column<decimal>(nullable: false),
                    KsldAwal = table.Column<decimal>(nullable: false),
                    ClrDate = table.Column<DateTime>(nullable: false),
                    AcctSet = table.Column<string>(nullable: true),
                    Kurs = table.Column<string>(nullable: true),
                    NonPpn = table.Column<bool>(nullable: false),
                    Saldo = table.Column<decimal>(nullable: false),
                    BankSld = table.Column<decimal>(nullable: false),
                    Debet = table.Column<decimal>(nullable: false),
                    Kredit = table.Column<decimal>(nullable: false),
                    KSaldo = table.Column<decimal>(nullable: false),
                    KBankSld = table.Column<decimal>(nullable: false),
                    KDebet = table.Column<decimal>(nullable: false),
                    KKredit = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.CbBankId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");
        }
    }
}
