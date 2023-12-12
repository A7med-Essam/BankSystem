using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    NationalId = table.Column<long>(type: "bigint", maxLength: 14, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.NationalId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ATM",
                columns: table => new
                {
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEmpty = table.Column<bool>(type: "bit", nullable: false),
                    OutOfService = table.Column<bool>(type: "bit", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATM", x => x.MachineId);
                    table.ForeignKey(
                        name: "FK_ATM_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountNumber = table.Column<long>(type: "bigint", maxLength: 16, nullable: false),
                    InterestRate = table.Column<float>(type: "real", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    Holder = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NationalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountNumber);
                    table.ForeignKey(
                        name: "FK_Account_Customer_NationalId",
                        column: x => x.NationalId,
                        principalTable: "Customer",
                        principalColumn: "NationalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complaint_Customer_NationalId",
                        column: x => x.NationalId,
                        principalTable: "Customer",
                        principalColumn: "NationalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    NationalId = table.Column<long>(type: "bigint", maxLength: 14, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bonus = table.Column<float>(type: "real", nullable: false),
                    Raise = table.Column<float>(type: "real", nullable: false),
                    OvertimeHours = table.Column<byte>(type: "tinyint", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deduction = table.Column<float>(type: "real", nullable: false),
                    SocialInsuranceRate = table.Column<float>(type: "real", nullable: false),
                    HealthInsuranceRate = table.Column<float>(type: "real", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.NationalId);
                    table.ForeignKey(
                        name: "FK_Employee_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterestRate = table.Column<float>(type: "real", nullable: false),
                    isApproved = table.Column<bool>(type: "bit", nullable: false),
                    LoanStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    NationalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loan_Account_AccountNumber",
                        column: x => x.AccountNumber,
                        principalTable: "Account",
                        principalColumn: "AccountNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loan_Employee_NationalId",
                        column: x => x.NationalId,
                        principalTable: "Employee",
                        principalColumn: "NationalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentCard",
                columns: table => new
                {
                    CardNumber = table.Column<int>(type: "int", nullable: false),
                    ExpireAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InitiatedIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardFees = table.Column<float>(type: "real", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    NationalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCard", x => x.CardNumber);
                    table.ForeignKey(
                        name: "FK_PaymentCard_Account_AccountNumber",
                        column: x => x.AccountNumber,
                        principalTable: "Account",
                        principalColumn: "AccountNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentCard_Employee_NationalId",
                        column: x => x.NationalId,
                        principalTable: "Employee",
                        principalColumn: "NationalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    NationalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Account_AccountNumber",
                        column: x => x.AccountNumber,
                        principalTable: "Account",
                        principalColumn: "AccountNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Employee_NationalId",
                        column: x => x.NationalId,
                        principalTable: "Employee",
                        principalColumn: "NationalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_NationalId",
                table: "Account",
                column: "NationalId");

            migrationBuilder.CreateIndex(
                name: "IX_ATM_BranchId",
                table: "ATM",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_NationalId",
                table: "Complaint",
                column: "NationalId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchId",
                table: "Employee",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_AccountNumber",
                table: "Loan",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_NationalId",
                table: "Loan",
                column: "NationalId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentCard_AccountNumber",
                table: "PaymentCard",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentCard_NationalId",
                table: "PaymentCard",
                column: "NationalId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AccountNumber",
                table: "Transaction",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_NationalId",
                table: "Transaction",
                column: "NationalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ATM");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "PaymentCard");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
