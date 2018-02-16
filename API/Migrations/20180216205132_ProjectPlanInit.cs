using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API.Migrations
{
    public partial class ProjectPlanInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerCentricScores",
                columns: table => new
                {
                    CustomerCentricScoreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerCentricScoreName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCentricScores", x => x.CustomerCentricScoreID);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    DivisionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DivisionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.DivisionID);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwnerName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerID);
                });

            migrationBuilder.CreateTable(
                name: "PP_BusinessUnits",
                columns: table => new
                {
                    BusinessUnitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessUnitDesc = table.Column<string>(nullable: true),
                    BusinessUnitName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PP_BusinessUnits", x => x.BusinessUnitID);
                });

            migrationBuilder.CreateTable(
                name: "PP_Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessUnitID = table.Column<int>(nullable: false),
                    CustomerCentricScore = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateEnded = table.Column<DateTime>(nullable: false),
                    DatePrevEnded = table.Column<DateTime>(nullable: false),
                    DateStarted = table.Column<DateTime>(nullable: false),
                    Deliverable = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DivisionID = table.Column<int>(nullable: false),
                    IsChangedEndDate = table.Column<bool>(nullable: false),
                    OwnerID = table.Column<int>(nullable: false),
                    StatusID = table.Column<int>(nullable: false),
                    TaskCategoryID = table.Column<int>(nullable: false),
                    TaskID = table.Column<int>(nullable: false),
                    TaskNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PP_Projects", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "TaskCategories",
                columns: table => new
                {
                    TaskCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaskCategoryDesc = table.Column<string>(nullable: true),
                    TaskCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskCategories", x => x.TaskCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_PP_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "PP_Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerMapCodes",
                columns: table => new
                {
                    CustomerMapCodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerMapCodeName = table.Column<string>(nullable: true),
                    ProjectsProjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMapCodes", x => x.CustomerMapCodeID);
                    table.ForeignKey(
                        name: "FK_CustomerMapCodes_PP_Projects_ProjectsProjectID",
                        column: x => x.ProjectsProjectID,
                        principalTable: "PP_Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KeyContacts",
                columns: table => new
                {
                    KeyContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KeyContactName = table.Column<string>(nullable: true),
                    ProjectsProjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyContacts", x => x.KeyContactID);
                    table.ForeignKey(
                        name: "FK_KeyContacts_PP_Projects_ProjectsProjectID",
                        column: x => x.ProjectsProjectID,
                        principalTable: "PP_Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProjectID",
                table: "Comments",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerMapCodes_ProjectsProjectID",
                table: "CustomerMapCodes",
                column: "ProjectsProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_KeyContacts_ProjectsProjectID",
                table: "KeyContacts",
                column: "ProjectsProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CustomerCentricScores");

            migrationBuilder.DropTable(
                name: "CustomerMapCodes");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "KeyContacts");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "PP_BusinessUnits");

            migrationBuilder.DropTable(
                name: "TaskCategories");

            migrationBuilder.DropTable(
                name: "PP_Projects");
        }
    }
}
