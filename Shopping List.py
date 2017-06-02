Items = []
Add_Item = []
for i in range(0,99999999) :
    Q = input("Enter [A] For Adding Or [R] For Removing Or [P] For Printing : ").upper()
    
    if Q == 'A' :
        Add_Item = input("Please Enter Your Item To Add It To Cart : ").upper()
        if Add_Item in Items :
            print("The Item Already Exists")
        else :
            Items.append(Add_Item)
    elif Q == 'R' :
        Add_Item = input("Please Enter Your Item To Remove It From Cart : ").upper()
        if Add_Item in Items :
            Items.remove(Add_Item)
        else :
            print(" The Item You Enterd Isn't Exist In The Cart ! ")
    elif Q == 'P' :
        print(" The Cart Now Has The Following Items : ",Items)
    else  :
        print("Please Enter A Valid Character ! ")
    
    
