using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class changeentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Addresses_AddressId",
                table: "Buildings");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_AddressId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "ConfirmationPhotoUrl",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Buildings",
                newName: "Address_ZipCode");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationPhotoUrl",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_City",
                table: "Buildings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Address_Number",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address_State",
                table: "Buildings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_Street",
                table: "Buildings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationPhotoUrl",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Address_City",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Address_Number",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Address_State",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Address_Street",
                table: "Buildings");

            migrationBuilder.RenameColumn(
                name: "Address_ZipCode",
                table: "Buildings",
                newName: "AddressId");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationPhotoUrl",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    ZipCode = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_AddressId",
                table: "Buildings",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Addresses_AddressId",
                table: "Buildings",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
