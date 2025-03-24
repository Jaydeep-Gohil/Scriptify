import mysql.connector
mydb = mysql.connector.connect(
        host="localhost",
        user="root",
        password=""
    )
mycursor = mydb.cursor()
mycursor.execute("create database e4")
mycursor.execute("Show Databases")
for x in mycursor:
    print(x)
