using Microsoft.EntityFrameworkCore.Migrations;

namespace Casgem_Mediator.Migrations
{
    public partial class mig_edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductBran",
                table: "Products",
                newName: "ProductBrand");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductBrand",
                table: "Products",
                newName: "ProductBran");
        }
    }
}
