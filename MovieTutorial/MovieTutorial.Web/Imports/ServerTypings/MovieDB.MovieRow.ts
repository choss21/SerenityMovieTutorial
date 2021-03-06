﻿namespace MovieTutorial.MovieDB {
    export interface MovieRow {
        MovieId?: number;
        Title?: string;
        Description?: string;
        Storyline?: string;
        Year?: number;
        ReleaseDate?: string;
        Runtime?: number;
        Kind?: MovieKind;
        TitleUpper?: string;
        GenreId?: number;
        GenreName?: string;
        CountryId?: number;
        CountryName?: string;
        StateCountryId?: number;
        StateCountryName?: string;
    }

    export namespace MovieRow {
        export const idProperty = 'MovieId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'MovieDB.Movie';
        export const deletePermission = 'Movie:General';
        export const insertPermission = 'Movie:General';
        export const readPermission = 'Movie:General';
        export const updatePermission = 'Movie:General';

        export declare const enum Fields {
            MovieId = "MovieId",
            Title = "Title",
            Description = "Description",
            Storyline = "Storyline",
            Year = "Year",
            ReleaseDate = "ReleaseDate",
            Runtime = "Runtime",
            Kind = "Kind",
            TitleUpper = "TitleUpper",
            GenreId = "GenreId",
            GenreName = "GenreName",
            CountryId = "CountryId",
            CountryName = "CountryName",
            StateCountryId = "StateCountryId",
            StateCountryName = "StateCountryName"
        }
    }
}
