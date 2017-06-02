Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
Message = input(" Please Enter Your Message :  ").upper()
Enc = ""

for l in Message :
    if l == " " :
        Enc += l
    elif Alphabet.index(l)+5 > len(Alphabet) :
        Enc += Alphabet[Alphabet.index(l)+5-26]
    else :
        Enc += Alphabet[Alphabet.index(l)+5]

print("Your Encrypted Message Is :  ",Enc)
