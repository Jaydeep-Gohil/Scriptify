import pandas as pd
data = {
    "Name": ["Alice", "Bob", "Charlie", "David", "Emma"],
    "Age": [25, 30, 35, 28, 40],
    "Salary": ["50,000", "60,000", "70,000", "55,000", "80,000"],
    "Department": ["HR", "IT", "Finance", "Marketing", "IT"]
    }
df = pd.DataFrame(data)
df.to_csv("task.csv")
#columns Remove
rm = df.drop(columns=["Age"])
print("Column Removed")
#Add New Columns
df["Exprience"]=[2,5,7,3,10]
print(df)
#Remove Multiple Columns
rm=df.drop(columns=["Salary","Department"])
print(rm)
#Select Name And Salary
ns = df[["Name", "Salary"]]
print(ns)
#Select Who Work IT DEPT.
it_dept=df[df["Department"]=="IT"]
print(it_dept)

