using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rpiThermo.Migrations
{
    public partial class fixes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Start_Time",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<DateTime>(
                name: "End_Time",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(TimeSpan));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Start_Time",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "End_Time",
                table: "Schedule",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
