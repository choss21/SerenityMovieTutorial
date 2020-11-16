
namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return 'MovieDB.Movie'; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
        protected getQuickSearchFields():
            Serenity.QuickSearchField[] {
            return [
                { name: "", title: "Todos" },
                { name: "Description", title: "Descripcion" },
                { name: "Storyline", title: "Historia" },
                { name: "Year", title: "Año" }
            ];
        }
        protected getQuickFilters() {
            debugger;
            return super.getQuickFilters();
        }
    }
}