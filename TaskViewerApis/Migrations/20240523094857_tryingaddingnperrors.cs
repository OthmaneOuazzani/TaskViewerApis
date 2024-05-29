using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskViewerApis.Migrations
{
    /// <inheritdoc />
    public partial class tryingaddingnperrors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Errors",
                columns: table => new
                {
                    PlmId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tokill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Workshop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contributors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseAsKpiFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastTouch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectiveAction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedObject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Errors", x => x.PlmId);
                });

            migrationBuilder.CreateTable(
                name: "Nps",
                columns: table => new
                {
                    PlmId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadedCurrvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadedIntmvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadedRefvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockFlag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LockUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncludedCurrvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncludedIntmvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncludedRefvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decpsa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypenpOrvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypenpUservalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseVeh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextnpByDecpsa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImplementationArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryperimeterOrvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryperimeterUservalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigurationContext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaLinks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BelongstopcConfCurrvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BelongstopcConfIntmvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BelongstopcConfRefvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tasks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<int>(type: "int", nullable: true),
                    ErrorsCurrvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorsIntmvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorsRefvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassificationOrvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassificationUservalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbpaCurrvalue = table.Column<int>(type: "int", nullable: true),
                    NbpaIntmvalue = table.Column<int>(type: "int", nullable: true),
                    NbpaRefvalue = table.Column<int>(type: "int", nullable: true),
                    XxErCv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XxErIv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XxErRv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationValidation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tokill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KpiCalled = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastTouch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kb01Pconfs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseVehicleInNp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleInNp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleTypeInNp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowertrainInNp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildpaCurrvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildpaIntmvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildpaRefvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrordescCurrvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrordescIntmvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrordescRefvalue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentinCurrvalue = table.Column<int>(type: "int", nullable: true),
                    PresentinIntmvalue = table.Column<int>(type: "int", nullable: true),
                    PresentinRefvalue = table.Column<int>(type: "int", nullable: true),
                    TaskLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortraitRobot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrfMetierSpec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffRestriction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WinAttachement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnaErrors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnaCombinationsCount = table.Column<int>(type: "int", nullable: true),
                    DnaHolesCount = table.Column<int>(type: "int", nullable: true),
                    DnaBumpsCount = table.Column<int>(type: "int", nullable: true),
                    DnaOtherErrorsCount = table.Column<int>(type: "int", nullable: true),
                    DnaMaxCombines = table.Column<int>(type: "int", nullable: true),
                    IsDnaCombinationsFull = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnaIsUptodate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnaTaskAction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnaTaskRcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnaTaskRcdFeedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnaTaskDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EffRestrictionIsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestEvent = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousRestriction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancelledAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nps", x => x.PlmId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Errors");

            migrationBuilder.DropTable(
                name: "Nps");
        }
    }
}
