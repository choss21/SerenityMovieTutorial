namespace MovieTutorial.MovieDB {
    export interface StateCountryForm {
        Name: Serenity.StringEditor;
        CountryId: Serenity.LookupEditor;
    }

    export class StateCountryForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.StateCountry';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StateCountryForm.init)  {
                StateCountryForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(StateCountryForm, [
                    'Name', w0,
                    'CountryId', w1
                ]);
            }
        }
    }
}
