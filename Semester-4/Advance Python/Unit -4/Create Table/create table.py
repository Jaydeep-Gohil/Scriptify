import mysql.connector
mydb = mysql.connector.connect(
        host="localhost",
        user="root",
        password="",
        database="python1"
    )
mycursor=mydb.cursor()
mycursor.execute("create table emp(id int,name varchar(25))")
mycursor.execute("Show Table")
for x in mycursor:
    print(x)
