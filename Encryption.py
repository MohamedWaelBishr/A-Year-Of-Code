while True :
    Encrypted_Key = {"A":"Z","B":"Y","C":"X","D":"W","E":"V","F":"U","G":"T",
                 "H":"S","I":"Q","J":"P","K":"R","L":"O","M":"N","N":"M","O":"L","R":"K",
                 "P":"J","Q":"I","S":"H","T":"G","U":"F","V":"E","W":"D","X":"C","Y":"B","Z":"A"," ":" "}



    Message = input(" Please Enter Your Message To Encrypt It:  ").upper()
    Encrypted = ""
    for letter in Message :
        if letter in Encrypted_Key :
            Encrypted += Encrypted_Key[letter]
        else :
            Encrypted += letter
    print(" The Encrypted Message Is : " , Encrypted )


    

        
