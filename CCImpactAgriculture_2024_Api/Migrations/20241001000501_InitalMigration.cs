using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace CCImpactAgriculture_2024_Api.Migrations
{
    /// <inheritdoc />
    public partial class InitalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CCItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "longtext", nullable: false),
                    Region = table.Column<string>(type: "longtext", nullable: false),
                    Crop_Type = table.Column<string>(type: "longtext", nullable: false),
                    Average_Temperature_C = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total_Precipitation_mm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CO2_Emissions_MT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Crop_Yield_MT_per_HA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Extreme_Weather_Events = table.Column<int>(type: "int", nullable: false),
                    Irrigation_Access_Per = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pesticide_Use_KG_per_HA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fertilizer_Use_KG_per_HA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Soil_Health_Index = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Adaptation_Strategies = table.Column<string>(type: "longtext", nullable: false),
                    Economic_Impact_Million_USD = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCItem", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CCItem");
        }
    }
}
