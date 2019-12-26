using Microsoft.EntityFrameworkCore.Migrations;

namespace Magnajaya.Data.Migrations
{
    public partial class addcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Srccode_CbGrp_CbGrpId",
                table: "Srccode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Srccode",
                table: "Srccode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CbGrp",
                table: "CbGrp");

            migrationBuilder.RenameTable(
                name: "Srccode",
                newName: "CbCodes");

            migrationBuilder.RenameTable(
                name: "CbGrp",
                newName: "CbGroups");

            migrationBuilder.RenameIndex(
                name: "IX_Srccode_CbGrpId",
                table: "CbCodes",
                newName: "IX_CbCodes_CbGrpId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CbCodes",
                table: "CbCodes",
                column: "CbSrccdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CbGroups",
                table: "CbGroups",
                column: "CbGrpId");

            migrationBuilder.AddForeignKey(
                name: "FK_CbCodes_CbGroups_CbGrpId",
                table: "CbCodes",
                column: "CbGrpId",
                principalTable: "CbGroups",
                principalColumn: "CbGrpId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CbCodes_CbGroups_CbGrpId",
                table: "CbCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CbGroups",
                table: "CbGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CbCodes",
                table: "CbCodes");

            migrationBuilder.RenameTable(
                name: "CbGroups",
                newName: "CbGrp");

            migrationBuilder.RenameTable(
                name: "CbCodes",
                newName: "Srccode");

            migrationBuilder.RenameIndex(
                name: "IX_CbCodes_CbGrpId",
                table: "Srccode",
                newName: "IX_Srccode_CbGrpId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CbGrp",
                table: "CbGrp",
                column: "CbGrpId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Srccode",
                table: "Srccode",
                column: "CbSrccdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Srccode_CbGrp_CbGrpId",
                table: "Srccode",
                column: "CbGrpId",
                principalTable: "CbGrp",
                principalColumn: "CbGrpId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
