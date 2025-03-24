import mysql.connector
mydb = mysql.connector.connect(
    host="localhost",
    user="root",
    password="",
    database="python1"
    )
mycursor=mydb.cursor()
sql="insert into emp(id,name)values(%s,%s)"
val=(1,"Jaydeep")
mycursor.execute(sql,val)
mydb.commit()
print(mycursor.rowcount,"Record Inserted")
