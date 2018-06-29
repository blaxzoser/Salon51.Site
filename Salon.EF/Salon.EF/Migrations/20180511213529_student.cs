using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Salon.EF.Migrations
{
    public partial class student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    PromotionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<decimal>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Percent = table.Column<int>(nullable: false),
                    Register = table.Column<DateTime>(nullable: false),
                    Until = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.PromotionID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    From = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    Register = table.Column<string>(nullable: true),
                    TypePublicity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<decimal>(nullable: true),
                    CostTotal = table.Column<decimal>(nullable: true),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    PromotionID = table.Column<int>(nullable: false),
                    Register = table.Column<DateTime>(nullable: false),
                    TypeCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payment_Promotion_PromotionID",
                        column: x => x.PromotionID,
                        principalTable: "Promotion",
                        principalColumn: "PromotionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ClassID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fri = table.Column<bool>(nullable: false),
                    IndividualCost = table.Column<decimal>(nullable: true),
                    Mon = table.Column<bool>(nullable: false),
                    MounthCost = table.Column<decimal>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Sat = table.Column<bool>(nullable: false),
                    Schedule = table.Column<string>(nullable: true),
                    Sun = table.Column<bool>(nullable: false),
                    TeacherID = table.Column<int>(nullable: true),
                    Thu = table.Column<bool>(nullable: false),
                    TotalCost = table.Column<decimal>(nullable: true),
                    Tue = table.Column<bool>(nullable: false),
                    TypeClass = table.Column<int>(nullable: false),
                    Wen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_Class_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubscriptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Register = table.Column<DateTime>(nullable: false),
                    StudenID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubscriptionID);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Class_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Class",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Student_StudenID",
                        column: x => x.StudenID,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_TeacherID",
                table: "Class",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PromotionID",
                table: "Payment",
                column: "PromotionID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Name",
                table: "Student",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_ClassID",
                table: "Subscriptions",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_StudenID",
                table: "Subscriptions",
                column: "StudenID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
