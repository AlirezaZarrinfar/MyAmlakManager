using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Amlak.Persistance.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amlaks_Users_UserId",
                table: "Amlaks");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Amlaks",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Amlaks_Users_UserId",
                table: "Amlaks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amlaks_Users_UserId",
                table: "Amlaks");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Amlaks",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Amlaks_Users_UserId",
                table: "Amlaks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
