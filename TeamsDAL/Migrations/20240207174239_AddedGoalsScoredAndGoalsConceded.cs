﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamsDAL.Migrations
{
    public partial class AddedGoalsScoredAndGoalsConceded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoalsConceded",
                table: "teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoalsScored",
                table: "teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoalsConceded",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "GoalsScored",
                table: "teams");
        }
    }
}
