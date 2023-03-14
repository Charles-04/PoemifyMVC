using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poemify.DAL.Migrations
{
    public partial class AddedForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poems_Users_UserId",
                table: "Poems");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Poems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Poems_Users_UserId",
                table: "Poems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poems_Users_UserId",
                table: "Poems");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Poems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Poems_Users_UserId",
                table: "Poems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
