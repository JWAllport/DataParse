1. A thorough analysis document detailing your approach and potential options for extensibility if
you had more time
First of all, with having two file types, I decided to have two classes that will parse through each file type (JSON, CSV) separately. 
- I initially planned on creating a class object that correlates to the file, however, since no file or format was provided I opted to use the dynamic type when parsing the files.
- Dynamic keyword will allow me to parse files with different data, requiring no hard-coded classes.
- At the end of processing, the data parsed is written to a log file.
- Unit tests, I created several tests generating files, and seeing if the correct number of records was detected. I also tested for bad file types, malformed files,
  and files with null data.


2. Detail on how you would progress further or improve the solution if time were not limited.

First, I would determine if any format or example files can be provided to better determine how to organize the parse. Whether using dynamic lists or creating custom objects. 
How the data is to be used would also be good to know, storing the data in a SQL database may be considered.
Next, I would create a more friendly user interface, instead of typing the file to load in the command line, I would have a file browser pop-up.
Lastly, I would create more unit tests, exploring files with bad characters, more examples of malformed data, and other common problems. 
