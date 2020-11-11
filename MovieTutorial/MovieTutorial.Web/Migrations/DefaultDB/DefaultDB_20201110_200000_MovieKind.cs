using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20201110200000)]
    public class DefaultDB_20201110_200000_MovieKind : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie")
                .AddColumn("Kind").AsInt32().NotNullable()
                    .WithDefaultValue(1);
        }

        public override void Down()
        {
        }
    }
}