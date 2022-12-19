# SumOfArguments

******************************************************************************
Program SumOfArguments tries to sum two arguments of type decimal (the 
decimal value type represents decimal numbers ranging from positive 
79,228,162,514,264,337,593,543,950,335 to negative 
79,228,162,514,264,337,593,543,950,335.) received by parameter. If the 
entered arguments are not decimal, the program adds them as two strings
(concatenates them). After the sum, the program saves the operation 
in the database and finally displays a history of all the arguments that 
have been entered into the database.

At the architecture level, and due to the simplicity of the application,
it has been decided to create an "old school" application without dependency 
injection, service collections, and all the modern tools provided by .NET 
Core. In this way the application is much more readable and understandable.
Then it has been decided to use sqlite to avoid having to use containers 
(docker) with a sql server installation. In fact, if there had not been a
requirement to use a sql database to save the values of the operations, the
values would have been saved in a json file to make everything even simpler. 
For this same reason, EntityFramework has been used to access the database, 
because it is very simple, readable, and on the other hand, the application 
did not require high levels of performance. Finally, to encrypt the database
file, a password has been set in the sqlite connection string.
******************************************************************************
 
