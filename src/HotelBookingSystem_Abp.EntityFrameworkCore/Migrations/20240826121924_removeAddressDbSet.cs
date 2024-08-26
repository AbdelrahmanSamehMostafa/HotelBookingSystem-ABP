using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingSystem_Abp.Migrations
{
    /// <inheritdoc />
    public partial class removeAddressDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.AddColumn<string>(
                name: "Address_City",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_Country",
                table: "Hotel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_City",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "Address_Country",
                table: "Hotel");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Address_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
