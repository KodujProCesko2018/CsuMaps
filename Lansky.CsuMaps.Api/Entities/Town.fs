module Entities

type Town = {
    Id : int32;
    Name : string;
    Year : int32;
    ``Start of the year population``: int32;
    ``End of the year population``: int32;
    Births: int32;
    Deaths: int32;
    Immigration: int32;
    Emigration: int32;
}