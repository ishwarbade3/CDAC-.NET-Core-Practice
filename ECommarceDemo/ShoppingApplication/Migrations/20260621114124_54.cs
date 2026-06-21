using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingApplication.Migrations
{
    /// <inheritdoc />
    public partial class _54 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "invoiceId",
                table: "Invoices",
                newName: "InvoiceId");

            migrationBuilder.RenameColumn(
                name: "Customercity",
                table: "Customers",
                newName: "CustomerCity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InvoiceId",
                table: "Invoices",
                newName: "invoiceId");

            migrationBuilder.RenameColumn(
                name: "CustomerCity",
                table: "Customers",
                newName: "Customercity");
        }
    }
}
