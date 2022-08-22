using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreWebAPI2.Migrations
{
    public partial class CoreWebAPI2DataApplicationDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TextTable",
                columns: table => new
                {
                    TextId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextTable", x => x.TextId);
                });

            migrationBuilder.InsertData(
                table: "TextTable",
                columns: new[] { "TextId", "TextString" },
                values: new object[] { 1L, "Numbers and alphabets are the basic teachings that a child learns in the house even before his steps reach the door of the school. This is the main foundation of their learning process. As the child starts going to school, he/she discovers how to spell words and numbers. They learn to differentiate the sounds and pronunciation of the words and numbers. And finally, they understand why we use numbers and words. These simple components become an undeniable part of their existence then and in the years to come. Be it anywhere in life, numbers are a facet no one can wave away. Be it in everyday usage or in making important decisions, numbers have a chance in representing facts which wouldn’t be possible otherwise. " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TextTable");
        }
    }
}
