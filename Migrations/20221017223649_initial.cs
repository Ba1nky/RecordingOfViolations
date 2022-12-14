using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecordingOfViolations.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentСhecks",
                columns: table => new
                {
                    PaymentСheckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViolationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentСhecks", x => x.PaymentСheckId);
                });

            migrationBuilder.CreateTable(
                name: "Violations",
                columns: table => new
                {
                    ViolationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Policeman = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Offender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Violations", x => x.ViolationId);
                });

            migrationBuilder.InsertData(
                table: "Violations",
                columns: new[] { "ViolationId", "Address", "Date", "Offender", "Policeman", "Price", "Reason" },
                values: new object[,]
                {
                    { 1, "вулиця Інститутська, 22", new DateTime(2022, 10, 10, 1, 36, 48, 904, DateTimeKind.Local).AddTicks(9181), "Cпівак Олег", "Кукурудза Валерій", 1750m, "Порушення правил користування ременями безпеки або мотошоломами" },
                    { 2, "Львівське шосе, 38/1", new DateTime(2022, 9, 25, 1, 36, 48, 904, DateTimeKind.Local).AddTicks(9188), "Ткачук Петро", "Щур Сергій", 510m, "Нетверезий стан" },
                    { 3, "вулиця Соборна, 11", new DateTime(2022, 10, 16, 1, 36, 48, 904, DateTimeKind.Local).AddTicks(9195), "Олійник Яна", "Щур Сергій", 750m, "Порушення правил перевезення дітей" },
                    { 4, "вулиця Трудова, 6А", new DateTime(2022, 10, 4, 1, 36, 48, 904, DateTimeKind.Local).AddTicks(9202), "Пристувчук Олександр", "Кукурудза Валерій", 15000m, "Порушення правил зупинки маршрутних таксі" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentСhecks");

            migrationBuilder.DropTable(
                name: "Violations");
        }
    }
}
