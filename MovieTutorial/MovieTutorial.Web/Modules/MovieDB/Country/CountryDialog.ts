
namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class CountryDialog extends Serenity.EntityDialog<CountryRow, any> {
        protected getFormKey() { return CountryForm.formKey; }
        protected getIdProperty() { return CountryRow.idProperty; }
        protected getLocalTextPrefix() { return CountryRow.localTextPrefix; }
        protected getNameProperty() { return CountryRow.nameProperty; }
        protected getService() { return CountryService.baseUrl; }
        protected getDeletePermission() { return CountryRow.deletePermission; }
        protected getInsertPermission() { return CountryRow.insertPermission; }
        protected getUpdatePermission() { return CountryRow.updatePermission; }

        protected form = new CountryForm(this.idPrefix);

    }
}