using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Senai2025Api.Migrations
{
    public partial class ajsutadocidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<int>(
            //    name: "Cidade",
            //    table: "Endereco",
            //    type: "integer",
            //    maxLength: 60,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "character varying(60)",
            //    oldMaxLength: 60);
            migrationBuilder.Sql(@"
            ALTER TABLE ""Endereco"" 
            ALTER COLUMN ""Cidade"" TYPE integer 
            USING ""Cidade""::integer;
        ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            ALTER TABLE ""Endereco"" 
            ALTER COLUMN ""Cidade"" TYPE character varying(60)
            USING ""Cidade""::text;
        ");
        }
    }
}
