
def employee(eid: str,name: str,designation: str,dateOfBirth: str,dateOfJoining: str,salary = 25000) -> None:
    print("==========================================================")
    print("Employe ID              : ",eid)
    print("Employe Name            : ",name)
    print("Employe Designation     : ",designation)
    print("Employe Date Of Birth   : ",dateOfBirth)
    print("Employe Date Of Joininh : ",dateOfJoining)
    print("==========================================================")
    print("Base Salary             : ",salary)
    print("House Renting Allowance : ",5000)
    print("Travelling Allowance    : ",2000)
    print("Providend Fund          : ",1500)
    print("Tax                     : ",200)
    print("==========================================================")
    print("Net Gross Salary        : ",(salary + 7000 - 1500) - 200)
    print("==========================================================")
    
employee("E001", "John Doe", "Software Engineer", "1985-06-15", "2015-08-01", 60000)
