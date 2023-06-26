using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendaDeLanches.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Normal', 'Lanches feitos com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Normal', 'Lanches feitos com ingredientes normais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
