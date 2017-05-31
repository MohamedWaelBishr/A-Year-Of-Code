Message = input("Please Enter Your Message :  ").upper()
Enc = ""
for l in Message :
    if l == " " :
        Enc += " "
    elif ord(l)+10 > ord("Z") :
        Enc += chr(ord(l)+10 - 26)
    else :
        Enc += chr(ord(l)+10)

print(" Your Encrypted Message Is :  ",Enc)          
