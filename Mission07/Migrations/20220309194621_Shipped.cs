using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission07.Migrations
{
    public partial class Shipped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Shipped",
            //    table: "Books");

            migrationBuilder.AddColumn<bool>(
                name: "Shipped",
                table: "Purchases",
                nullable: false,
                defaultValue: false);
        }

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropColumn(
        //        name: "Shipped",
        //        table: "Purchases");

        //    migrationBuilder.AddColumn<bool>(
        //        name: "Shipped",
        //        table: "Books",
        //        type: "INTEGER",
        //        nullable: false,
        //        defaultValue: false);
        //}
    }
}
