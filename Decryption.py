while True :
    Decrypted_Key = {"Z":"A","Y":"B","X":"C","W":"D","V":"E","U":"F","T":"G",
                     "S":"H","Q":"I","P":"J","R":"K","O":"L","N":"M","M":"N","L":"O","K":"R",
                     "J":"P","I":"Q","H":"S","G":"T","F":"U","E":"V","D":"W","C":"X","B":"Y","A":"Z"," ":" "}

    Message = input(" Please Enter Your Message To Decrypt It :  ").upper()
    Decrypted = ""
    for letter in Message :
        if letter in Decrypted_Key :
            Decrypted += Decrypted_Key[letter]
        else :
            Decrypted += letter
    print(" The Decrypted Message Is : " , Decrypted )

