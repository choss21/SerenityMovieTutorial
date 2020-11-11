﻿namespace MovieTutorial.MovieDB {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        TitleUpper: Serenity.StringEditor;
        Kind: Serenity.EnumEditor;
        GenreId: Serenity.LookupEditor;
        Description: Serenity.TextAreaEditor;
        Storyline: Serenity.TextAreaEditor;
        Year: Serenity.IntegerEditor;
        ReleaseDate: Serenity.DateEditor;
        Runtime: Serenity.IntegerEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EnumEditor;
                var w2 = s.LookupEditor;
                var w3 = s.TextAreaEditor;
                var w4 = s.IntegerEditor;
                var w5 = s.DateEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'TitleUpper', w0,
                    'Kind', w1,
                    'GenreId', w2,
                    'Description', w3,
                    'Storyline', w3,
                    'Year', w4,
                    'ReleaseDate', w5,
                    'Runtime', w4
                ]);
            }
        }
    }
}
