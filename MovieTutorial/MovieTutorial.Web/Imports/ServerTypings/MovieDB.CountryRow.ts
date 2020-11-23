namespace MovieTutorial.MovieDB {
    export interface CountryRow {
        CountryId?: number;
        Name?: string;
    }

    export namespace CountryRow {
        export const idProperty = 'CountryId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'MovieDB.Country';
        export const lookupKey = 'MovieDB.Country';

        export function getLookup(): Q.Lookup<CountryRow> {
            return Q.getLookup<CountryRow>('MovieDB.Country');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CountryId = "CountryId",
            Name = "Name"
        }
    }
}
