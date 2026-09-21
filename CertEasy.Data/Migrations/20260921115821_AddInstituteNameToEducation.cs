using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CertEasy.Data.Migrations
{
    public partial class AddInstituteNameToEducation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            if (migrationBuilder.ActiveProvider != null && migrationBuilder.ActiveProvider.Contains("SqlServer"))
            {
                migrationBuilder.Sql(@"
                    IF NOT EXISTS (SELECT * FROM sys.columns 
                                   WHERE object_id = OBJECT_ID(N'[dbo].[Educations]') 
                                   AND name = 'InstituteName')
                    BEGIN
                        ALTER TABLE [Educations] ADD [InstituteName] nvarchar(200) NULL;
                    END
                ");
            }
            else
            {
                migrationBuilder.AddColumn<string>(
                    name: "InstituteName",
                    table: "Educations",
                    type: "nvarchar(200)",
                    maxLength: 200,
                    nullable: true);
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            if (migrationBuilder.ActiveProvider != null && migrationBuilder.ActiveProvider.Contains("SqlServer"))
            {
                migrationBuilder.Sql(@"
                    IF EXISTS (SELECT * FROM sys.columns 
                               WHERE object_id = OBJECT_ID(N'[dbo].[Educations]') 
                               AND name = 'InstituteName')
                    BEGIN
                        ALTER TABLE [Educations] DROP COLUMN [InstituteName];
                    END
                ");
            }
            else
            {
                migrationBuilder.DropColumn(
                    name: "InstituteName",
                    table: "Educations");
            }
        }
    }
}
