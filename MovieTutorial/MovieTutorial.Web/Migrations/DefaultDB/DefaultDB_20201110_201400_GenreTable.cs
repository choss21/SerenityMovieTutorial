using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20201110201400)]
    public class DefaultDB_20201110_201400_GenreTable : Migration
    {
        public override void Up()
        {
            Create.Table("Genre")
                .WithColumn("GenreId").AsInt32().NotNullable()
                    .PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable();

            Alter.Table("Movie")
                .AddColumn("GenreId").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_GenreId", "dbo", "Genre", "GenreId");
        }

        public override void Down()
        {
        }
    }
}