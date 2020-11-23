
namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class CountryGrid extends Serenity.EntityGrid<CountryRow, any> {
        protected getColumnsKey() { return 'MovieDB.Country'; }
        protected getDialogType() { return CountryDialog; }
        protected getIdProperty() { return CountryRow.idProperty; }
        protected getInsertPermission() { return CountryRow.insertPermission; }
        protected getLocalTextPrefix() { return CountryRow.localTextPrefix; }
        protected getService() { return CountryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}