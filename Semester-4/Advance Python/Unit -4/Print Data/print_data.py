import mysql.connector
mydb = mysql.connector.connect(
        host="localhost",
        user="root",
        password="",
        database="python1"
    )
mycursor = mydb.cursor()
mycursor.execute("select * from emp")
myresult = mycursor.fetchall()
for x in myresult:
    print(x)
