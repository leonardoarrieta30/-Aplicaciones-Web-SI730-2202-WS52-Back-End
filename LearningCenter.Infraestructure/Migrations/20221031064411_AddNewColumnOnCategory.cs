using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningCenter.Infraestructure.Migrations
{
    public partial class AddNewColumnOnCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 1, 44, 11, 633, DateTimeKind.Local).AddTicks(4121),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 31, 1, 26, 29, 164, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Tutorials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 1, 44, 11, 633, DateTimeKind.Local).AddTicks(3442),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 31, 1, 26, 29, 164, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 60)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 1, 44, 11, 633, DateTimeKind.Local).AddTicks(2879),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 31, 1, 26, 29, 164, DateTimeKind.Local).AddTicks(5320));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 1, 26, 29, 164, DateTimeKind.Local).AddTicks(6625),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 31, 1, 44, 11, 633, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Tutorials",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 1, 26, 29, 164, DateTimeKind.Local).AddTicks(5930),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 31, 1, 44, 11, 633, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Categories",
                type: "int",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 1, 26, 29, 164, DateTimeKind.Local).AddTicks(5320),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 31, 1, 44, 11, 633, DateTimeKind.Local).AddTicks(2879));
        }
    }
}
