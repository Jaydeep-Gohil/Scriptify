import pandas as pd
dict = {"name":["jaydeep","Keval","jenil","om","nikhil"],
        "marks":[10,10,20,20,30],
        "city":["Chotila","Rajkot","Rajkot","Rajkot","Rajkot"]
    }
df = pd.DataFrame(dict)
print(df)
df.to_csv("Demo.csv",index=True)
rc = pd.read_csv("Demo.csv")
print(rc)

'''class rc():
    def __init__(self,read):
        self.read=pd.read_csv("Demo.csv")
    def show(self):
        print(self.read)
read="Demo.csv"
obj=rc(read)
obj.show()
'''
