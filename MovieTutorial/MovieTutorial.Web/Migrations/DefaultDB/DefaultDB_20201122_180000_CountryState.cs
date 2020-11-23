using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20201122180000)]
    public class DefaultDB_20201122_180000_CountryState : Migration
    {
        public override void Up()
        {
            Create.Table("Countries")
                .WithColumn("CountryId").AsInt32().NotNullable()
                    .PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable();
            Create.Table("StatesCountry")
               .WithColumn("StateCountryId").AsInt32().NotNullable()
                   .PrimaryKey().Identity()
               .WithColumn("Name").AsString(100).NotNullable()
               .WithColumn("CountryId").AsInt32().NotNullable()
                    .ForeignKey("FK_StatesCountryCountryId", "Countries", "CountryId");

            Alter.Table("Movie")
                .AddColumn("CountryId").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_CountryId", "Countries", "CountryId")
                .AddColumn("StateCountryid").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_StateCountryId", "StatesCountry", "StateCountryId");
        }

        public override void Down()
        {
        }
    }
}