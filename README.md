# Mock - CSVparser

In this Project, the main task is to create an appilication capable of parsing a CSV file and querying the results. 

## Technology used : 
C# to create a .NET application.

### Introduction :

The application need to read from a csv file given. The csv file contains 500 fake data in the file `csvmockk.csv`. After reading the CSV file, there are few things to perfrom as follows :

`OPTION 1`: Every person who has “Esq” in their company name.

`OPTION 2`: Every person who lives in “Derbyshire”.

`OPTION 3`: Every person whose house number is exactly three digits.

`OPTION 4`: Every person whose website URL is longer than 35 characters

`OPTION 5`: Every person who lives in a postcode area with a single-digit value.

`OPTION 6`: Every person whose first phone number is numerically larger than their second phone number.

The user can select any of the above options from the console. 

### Output :

Each output consists of a count and then a list of people which correspond to some criteria. Each person should be displayed on a new line consisting of their
position in the list and their name and their company.

For example, if the criteria was “Every person who is called ‘Karma Quarto’” then the output should be:

Count: 1
30 - Karma Quarto - J C S Machinery


