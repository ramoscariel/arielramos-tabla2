using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace arielramos_tabla2.Migrations
{
    public partial class Inicio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoId = table.Column<int>(type: "int", nullable: false),
                    PromoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyBurgerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promo_Burger_MyBurgerId",
                        column: x => x.MyBurgerId,
                        principalTable: "Burger",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promo_MyBurgerId",
                table: "Promo",
                column: "MyBurgerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promo");
        }
    }
}
