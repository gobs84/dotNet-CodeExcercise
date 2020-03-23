## Creation of the project

To create the .exe file first you have to perform the next commands inside the directory.
```bash
dotnet restore
dotnet build
```
This will create a file in "dotNet-CodeExcercise\bin\Debug", a `dotNet-CodeExcercise.exe`, this will be used to test the application

## Testing the application

The CSV file that has the students should be located in the same directory as `dotNet-CodeExcercise.exe` in order to work.
There are three available commands:

### Get students by name
To get students by name you run the next command, where you put the name of the CSV file as first argument and the student name in the second.
```bash
    dotNet-CodeExcercise.exe <csv file> name=<student name>
```
There is no particular order in the result of this request, because ordering alphabetically the same name is not logic.
### Get students by type
To get students by type you run the next command, where you put the name of the CSV file as first argument and the student type in the second.
```bash
    dotNet-CodeExcercise.exe <csv file> type=<student type>
```
Types:
* Kinder
* Elementary
* High
* University
### Get students by type and genre
To get students by type you run the next command, where you put the name of the CSV file as first argument, the student type in the second and finally as third argument the genre of the student
```bash
    dotNet-CodeExcercise.exe <csv file> type=<student type> genre=<student genre>
```
Genres:
* Female
* Male