
namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class StateCountryGrid extends Serenity.EntityGrid<StateCountryRow, any> {
        protected getColumnsKey() { return 'MovieDB.StateCountry'; }
        protected getDialogType() { return StateCountryDialog; }
        protected getIdProperty() { return StateCountryRow.idProperty; }
        protected getInsertPermission() { return StateCountryRow.insertPermission; }
        protected getLocalTextPrefix() { return StateCountryRow.localTextPrefix; }
        protected getService() { return StateCountryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}