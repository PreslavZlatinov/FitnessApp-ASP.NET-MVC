using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp_PreslavZlatinov_19621621.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKey_Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Workouts_WorkId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_WorkId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "WorkId",
                table: "OrderItems");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_WorkoutId",
                table: "OrderItems",
                column: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Workouts_WorkoutId",
                table: "OrderItems",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Workouts_WorkoutId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_WorkoutId",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "WorkId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_WorkId",
                table: "OrderItems",
                column: "WorkId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Workouts_WorkId",
                table: "OrderItems",
                column: "WorkId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
