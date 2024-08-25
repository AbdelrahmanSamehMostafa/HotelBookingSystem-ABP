using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingSystem_Abp.Migrations
{
    /// <inheritdoc />
    public partial class changedSuperAdminIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuperAdminId",
                table: "Admin");

            migrationBuilder.AddColumn<int>(
                name: "SuperAdminId",
                table: "Admin",
                type: "int",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
{
    migrationBuilder.DropColumn(
        name: "SuperAdminId",
        table: "Admin");

    migrationBuilder.AddColumn<Guid>(
        name: "SuperAdminId",
        table: "Admin",
        type: "uniqueidentifier",
        nullable: false);
}
    }
}
