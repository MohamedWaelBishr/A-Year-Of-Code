Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
Message = input(" Please Enter Your Message :  ").upper()
Dec = ""

for l in Message :
    if l == " " :
        Dec += l
    elif Alphabet.index(l) < 5 :
        Dec += Alphabet[Alphabet.index(l)+26-5]
    else :
        Dec += Alphabet[Alphabet.index(l)-5]

print("Your Decrypted Message Is :  ",Dec)
