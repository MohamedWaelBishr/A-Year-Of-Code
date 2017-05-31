Message = input("Please Enter Your Message :  ").upper()
Enc = ""
for l in Message :
    if l == " " :
        Enc += " "
    elif ord(l) < 75 :
        Enc += chr(ord(l)+26 -10)
    else :
        Enc += chr(ord(l)-10)

print(" Your Decrypted Message Is :  ",Enc)          
