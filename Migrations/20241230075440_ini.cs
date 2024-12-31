using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hadeelsamer.Migrations
{
    /// <inheritdoc />
    public partial class ini : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_projects_projectID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_teamMambers_TaskId",
                table: "Tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_projects_projectID",
                table: "Tasks",
                column: "projectID",
                principalTable: "projects",
                principalColumn: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_teamMambers_TaskId",
                table: "Tasks",
                column: "TaskId",
                principalTable: "teamMambers",
                principalColumn: "TeamMamberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_projects_projectID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_teamMambers_TaskId",
                table: "Tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_projects_projectID",
                table: "Tasks",
                column: "projectID",
                principalTable: "projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_teamMambers_TaskId",
                table: "Tasks",
                column: "TaskId",
                principalTable: "teamMambers",
                principalColumn: "TeamMamberId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
