using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MMEfCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class addedActivetoCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Customers");
        }
    }
}
