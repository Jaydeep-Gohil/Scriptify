import os
class aboutUs :
    def create(self):
        file = open("AboutUs.doc","w")
        file.write("Hello World...")
        file.close()
        print("File Created...")
    def read(self):
        try:
            file = open("AboutUs.doc","r")
            print(file.read())
            file.close()
        except:
            print("error")
    def append(self):
        file = open("AboutUs.doc","a")
        file.write("Atmiya")
        file.close()
        print("File Appended.")
    def delete(self):
        os.remove("AboutUs.doc")
        print("File Deleted...")
obj = aboutUs()
obj.create()
obj.read()
obj.append()
obj.delete()
obj.read()
