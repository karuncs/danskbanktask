# danskbanktask

The task is to create a small application, which manages taxes applied in different municipalities. The
taxes are scheduled in time. The application should provide the user an ability to get taxes applied in
certain municipality at the given day.

Part of the Solution, I have written some classes to produce and read the data in the project folder. We can run the entire
solution without making any database connections since I used a local folder as DB. The functionalities of the some of
the classes are

1. Local DB folder which is having the municipalities tax data. The data is in json format.
2. Producer.cs calss produce the municpality data and save it as a local file in DB with "municipality name".json.
If the municipality name is already extsts then the data will be appended to the same file.
Otherwise the program will create a new file with municipality name
3. Consumer.cs class reads the data of a specific municipality tax by entering municipality name and date.
4.  JSONReader.cs class parse the data
5. Program.cs has maain class where you could enter the input data for producer and consumer
6. Error




