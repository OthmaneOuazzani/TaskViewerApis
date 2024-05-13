using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskViewerApis.Migrations
{
    /// <inheritdoc />
    public partial class pppp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pdefs",
                columns: table => new
                {
                    PlmId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalIndex = table.Column<int>(type: "int", nullable: false),
                    LoadedCurrValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadedIntmValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadedRefValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadedHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockFlag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LockUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsaDeadline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GbomMaturity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MassEstimatedCurrValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MassEstimatedIntmValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MassEstimatedRefValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MassEstimatedHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MassType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Macsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignerPrefered = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avancement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tasks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flag = table.Column<int>(type: "int", nullable: false),
                    ErrorsCurrValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorsIntmValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorsRefValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorsHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BelongsToPConfCurrValue = table.Column<bool>(type: "bit", nullable: false),
                    BelongsToPConfIntmValue = table.Column<bool>(type: "bit", nullable: false),
                    BelongsToPConfRefValue = table.Column<bool>(type: "bit", nullable: false),
                    BelongsToPConfHistory = table.Column<bool>(type: "bit", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Applicability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountOfUses = table.Column<long>(type: "bigint", nullable: false),
                    DecPsa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignationEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignationFr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefPsa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tokill = table.Column<bool>(type: "bit", nullable: false),
                    BelongsToContext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfigurationContextes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HighestRevision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KpiCalled = table.Column<bool>(type: "bit", nullable: false),
                    LastTouch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colored = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cnxs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildPrea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorDescCurrValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorDescIntmValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorDescRefValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PsaEcheance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductNature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefFca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousApplicability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CancelledAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DecPsas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pdefs", x => x.PlmId);
                });

            migrationBuilder.CreateTable(
                name: "Preas",
                columns: table => new
                {
                    PlmId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalIndex = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadedCurrValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadedIntmValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadedRefValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadedHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockFlag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LockUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Psadeadline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MassCurrValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MassIntmValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MassRefValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MassHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignerPrefered = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avancement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pdef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tasks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flag = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ErrorsCurrValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorsIntmValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorsRefValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorsHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Applicability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountOfUses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DecPsa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignationEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignationFr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefPsa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tokill = table.Column<bool>(type: "bit", nullable: false),
                    BelongsToContextR = table.Column<bool>(type: "bit", nullable: false),
                    ConfigurationContextes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HighestRevision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BelongsToPConfCurrValue = table.Column<bool>(type: "bit", nullable: false),
                    BelongsToPConfIntmValue = table.Column<bool>(type: "bit", nullable: false),
                    BelongsToPConfRefValue = table.Column<bool>(type: "bit", nullable: false),
                    KpiCalled = table.Column<bool>(type: "bit", nullable: false),
                    LastTouch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorDescCurrValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorDescIntmValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorDescRefValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherPdef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousApplicability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CancelledAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preas", x => x.PlmId);
                });

            migrationBuilder.CreateTable(
                name: "Pref",
                columns: table => new
                {
                    PlmId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tokill = table.Column<bool>(type: "bit", nullable: false),
                    LockFlag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LockUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefPsa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PdefPlmId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNeutral = table.Column<bool>(type: "bit", nullable: false),
                    IsColored = table.Column<bool>(type: "bit", nullable: false),
                    ObjectId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnersRef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeutralPlmId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorCode3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorCode2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorDesignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancelledAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefPsaRev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecPsaList = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pref", x => x.PlmId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pdefs");

            migrationBuilder.DropTable(
                name: "Preas");

            migrationBuilder.DropTable(
                name: "Pref");
        }
    }
}
