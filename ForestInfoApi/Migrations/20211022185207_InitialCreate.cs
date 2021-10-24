using Microsoft.EntityFrameworkCore.Migrations;

namespace ForestInfoApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    DivisionCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ForestArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.DivisionCode);
                });

            migrationBuilder.CreateTable(
                name: "Range",
                columns: table => new
                {
                    RangeCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RangeName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ForestArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DivisionCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Range", x => x.RangeCode);
                    table.ForeignKey(
                        name: "FK_Range_Division_DivisionCode",
                        column: x => x.DivisionCode,
                        principalTable: "Division",
                        principalColumn: "DivisionCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    BlockCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockDescription = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ForestArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DivisionCode = table.Column<int>(type: "int", nullable: true),
                    RangeCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.BlockCode);
                    table.ForeignKey(
                        name: "FK_Block_Division_DivisionCode",
                        column: x => x.DivisionCode,
                        principalTable: "Division",
                        principalColumn: "DivisionCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Block_Range_RangeCode",
                        column: x => x.RangeCode,
                        principalTable: "Range",
                        principalColumn: "RangeCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    SectionNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NetArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DivisionCode = table.Column<int>(type: "int", nullable: true),
                    RangeCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.SectionNumber);
                    table.ForeignKey(
                        name: "FK_Section_Division_DivisionCode",
                        column: x => x.DivisionCode,
                        principalTable: "Division",
                        principalColumn: "DivisionCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Section_Range_RangeCode",
                        column: x => x.RangeCode,
                        principalTable: "Range",
                        principalColumn: "RangeCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompartmentCode = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NetForestArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossForestArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DivisionCode = table.Column<int>(type: "int", nullable: true),
                    RangeCode = table.Column<int>(type: "int", nullable: true),
                    BlockCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compartment_Block_BlockCode",
                        column: x => x.BlockCode,
                        principalTable: "Block",
                        principalColumn: "BlockCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compartment_Division_DivisionCode",
                        column: x => x.DivisionCode,
                        principalTable: "Division",
                        principalColumn: "DivisionCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compartment_Range_RangeCode",
                        column: x => x.RangeCode,
                        principalTable: "Range",
                        principalColumn: "RangeCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Beat",
                columns: table => new
                {
                    BeatNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeatName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NetArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DivisionCode = table.Column<int>(type: "int", nullable: true),
                    RangeCode = table.Column<int>(type: "int", nullable: true),
                    SectionNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beat", x => x.BeatNumber);
                    table.ForeignKey(
                        name: "FK_Beat_Division_DivisionCode",
                        column: x => x.DivisionCode,
                        principalTable: "Division",
                        principalColumn: "DivisionCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beat_Range_RangeCode",
                        column: x => x.RangeCode,
                        principalTable: "Range",
                        principalColumn: "RangeCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beat_Section_SectionNumber",
                        column: x => x.SectionNumber,
                        principalTable: "Section",
                        principalColumn: "SectionNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beat_DivisionCode",
                table: "Beat",
                column: "DivisionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Beat_RangeCode",
                table: "Beat",
                column: "RangeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Beat_SectionNumber",
                table: "Beat",
                column: "SectionNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Block_DivisionCode",
                table: "Block",
                column: "DivisionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Block_RangeCode",
                table: "Block",
                column: "RangeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Compartment_BlockCode",
                table: "Compartment",
                column: "BlockCode");

            migrationBuilder.CreateIndex(
                name: "IX_Compartment_DivisionCode",
                table: "Compartment",
                column: "DivisionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Compartment_RangeCode",
                table: "Compartment",
                column: "RangeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Range_DivisionCode",
                table: "Range",
                column: "DivisionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Section_DivisionCode",
                table: "Section",
                column: "DivisionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Section_RangeCode",
                table: "Section",
                column: "RangeCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beat");

            migrationBuilder.DropTable(
                name: "Compartment");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropTable(
                name: "Range");

            migrationBuilder.DropTable(
                name: "Division");
        }
    }
}
