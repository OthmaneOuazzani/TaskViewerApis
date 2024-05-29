using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskViewerApis.Migrations
{
    /// <inheritdoc />
    public partial class deletedcolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "Nps",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlmId",
                table: "Nps",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nps",
                table: "Nps",
                columns: new[] { "PlmId", "ProjectName" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Nps",
                table: "Nps");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PlmId",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "BelongstopcConfCurrvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BelongstopcConfIntmvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BelongstopcConfRefvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassificationOrvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassificationUservalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErrorsCurrvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErrorsIntmvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErrorsRefvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FactoryperimeterOrvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FactoryperimeterUservalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IncludedCurrvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IncludedIntmvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IncludedRefvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoadedCurrvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoadedIntmvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoadedRefvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NbpaCurrvalue",
                table: "Nps",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NbpaIntmvalue",
                table: "Nps",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NbpaRefvalue",
                table: "Nps",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextnpByDecpsa",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaLinks",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypenpOrvalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypenpUservalue",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Nps",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
