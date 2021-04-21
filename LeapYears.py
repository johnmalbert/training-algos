def is_leap(year):
    leap = False
    
    # Write your logic here
    if(year % 4 == 0):
        if(year % 100 == 0):
            if(year % 400 == 0):
                leap = True
            else:
                leap = False
        else:
            leap = True
    print("Is " + str(year) + " a leap year? ")
    if(leap):
        print("It is!")
    else:
        print("No, it isn't.")
    return leap

year = int(input())
is_leap(year)