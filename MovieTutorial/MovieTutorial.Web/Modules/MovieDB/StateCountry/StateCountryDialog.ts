
namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class StateCountryDialog extends Serenity.EntityDialog<StateCountryRow, any> {
        protected getFormKey() { return StateCountryForm.formKey; }
        protected getIdProperty() { return StateCountryRow.idProperty; }
        protected getLocalTextPrefix() { return StateCountryRow.localTextPrefix; }
        protected getNameProperty() { return StateCountryRow.nameProperty; }
        protected getService() { return StateCountryService.baseUrl; }
        protected getDeletePermission() { return StateCountryRow.deletePermission; }
        protected getInsertPermission() { return StateCountryRow.insertPermission; }
        protected getUpdatePermission() { return StateCountryRow.updatePermission; }

        protected form = new StateCountryForm(this.idPrefix);

    }
}