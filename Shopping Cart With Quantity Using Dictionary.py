Cart = {}

print("""
-------------------------
Shopping Program Options
-------------------------
A : Adding New Item
R : Removing Existing Item
P : Print The Shopping Cart
E : Exit Shopping Program
-------------------------
""")
Option = input(" Please Enter An Option : ").upper()
while True :
    if Option == "A" :
        item = input(" Please Enter Your Item : ").upper()
        if item in  Cart :
            print(" The Item Alrady Exists In The Cart ")
            Qn = int(input(" Please Enter The Quantity Of {0} : ".format(item)))
            Cart[item] += Qn
        else :
            Qn = int(input(" Please Enter The Quantity Of {0} : ".format(item)))
            Cart[item] = Qn
    elif Option == "R" :
        item = input(" Please Enter Your Item : ").upper()
        if item in Cart :
            del(Cart[item])
            print(" {0} Is Now Removed From The Cart ".format(item))
        else :
            print(" The Item Is Not In The Cart ")
    elif Option == "P" :
        print("--------------------------------------")
        print("Your Cart Now Has The Following Items ")
        print("--------------------------------------")
        for item in Cart :
            print(item," : ",Cart[item])
        print("--------------------------------------")
    elif Option == "E" :
        print(" Shopping Cart Program Closed . ")
        break
    else :
        print(" Please Enter A Valid Character ")
        
    Option = input(" Please Enter An Option : ").upper()


    
        
