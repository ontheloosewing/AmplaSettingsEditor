using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmplaSettingsEditor.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmplaField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    NameEnglish = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    NameRussian = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    NameFull = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RpId = table.Column<int>(nullable: false),
                    RpNameFull = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RpType = table.Column<string>(nullable: true),
                    SapId = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmplaField", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmplaField");
        }
    }
}
