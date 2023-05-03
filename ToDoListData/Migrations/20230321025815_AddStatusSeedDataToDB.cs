using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListData.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusSeedDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO StatusTable (Name) VALUES ('To Do');");
            migrationBuilder.Sql("INSERT INTO StatusTable (Name) Values ('In Progress');");
            migrationBuilder.Sql("INSERT INTO StatusTable (Name) Values ('Done');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
