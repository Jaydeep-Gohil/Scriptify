# Required Args
def reqArgs(name,age):
    print("My Name is : ",name)
    print("My Age is  : ",age)
reqArgs("Jaydeep Gohil",19)

# Default Args
def defaultArgs(name,age = 18):
    print("My Name is : ",name)
    print("My Age is  : ",age)
defaultArgs("Jaydeep Gohil")

#Keyword Args
def keywordArgs(name,age):
    print("My Name is : ",name)
    print("My Age is  : ",age)
keywordArgs(name = "Jaydeep Gohil", age = 19)

# Variable Args
def variableArgs(*nums):
    print("All The Arguments : ",nums)
variableArgs(1,2,3,4,5)