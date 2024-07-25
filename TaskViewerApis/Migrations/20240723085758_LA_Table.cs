using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskViewerApis.Migrations
{
    /// <inheritdoc />
    public partial class LA_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Las",
                columns: table => new
                {
                    PlmId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ToKill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedConf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedConfTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliverableType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avancement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgreedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EcoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EcoState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfiedByType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfiedByRevision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfiedByState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfiedByEco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfiedByEcoState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cotert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoterAl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecPsa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectPackage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Errors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectNameList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastTouch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContextObjectId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContextType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Leader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagementState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ObjectId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectOwnership = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectSpaceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectSpaceObjectId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatisfiedByObjectId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectSpace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToDoBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LockFlag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cnx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FunctionalPackage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancelledAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Las", x => x.PlmId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Las");
        }
    }
}
