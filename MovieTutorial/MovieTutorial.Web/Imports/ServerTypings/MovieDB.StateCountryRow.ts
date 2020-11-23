namespace MovieTutorial.MovieDB {
    export interface StateCountryRow {
        StateCountryId?: number;
        Name?: string;
        CountryId?: number;
        CountryName?: string;
    }

    export namespace StateCountryRow {
        export const idProperty = 'StateCountryId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'MovieDB.StateCountry';
        export const lookupKey = 'MovieDB.StateCountry';

        export function getLookup(): Q.Lookup<StateCountryRow> {
            return Q.getLookup<StateCountryRow>('MovieDB.StateCountry');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            StateCountryId = "StateCountryId",
            Name = "Name",
            CountryId = "CountryId",
            CountryName = "CountryName"
        }
    }
}
