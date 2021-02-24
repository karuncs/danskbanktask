# Dansk Bank Task - Buying & Owning Real Estate Nordic

### Author: Karunakar Bayyapu 

## Task Description: 
The task is to create a small application, which manages taxes applied in different municipalities. The
taxes are scheduled in time. The application should provide the user an ability to get taxes applied in
certain municipality at the given day.

## Solution
Part of the Solution, I have written interfaces and classes to produce and read the data in the project folder. You can run the entire
solution without making any database connections since I used a local folder as DB where the all input files data will be stored. The functionalities of the the classes are

1. Local DB folder which is having the municipalities tax data and errors log data. The municipalities data is in json format. Logs data is in .txt format.
2. Program.cs has maain class where I called producer and consumer.
3. In the InputData.cs class, you have to provide input data in invokeProducer() for producer to insert data. 
    You can also enter municipality and date in invokeCosumer() to get tax information.
4. Producer.cs calss produce the municpality data and save it as a local file in DB with "municipality name".json.
If the municipality name is already extsts then the data will be appended to the same file. Otherwise the program will create a new file with municipality name and write the data in it
5. Consumer.cs class reads the data of a specific municipality tax by entering municipality name and date.
6. Muncipality.cs class defines all type taxes with periods
7. JSONReader.cs class parse the data
8. ErrorHandling.cs class handles some of the exceptions which is called in different classes.





