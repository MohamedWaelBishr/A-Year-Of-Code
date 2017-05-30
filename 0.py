while True :
    get_name = [ str(x) for x in input('Please Enter Your Name :  ').split(' ')]
    name = ''
    duplicated = ''
    for i in get_name :
         if i not in name :
            name += i+' '
         elif i in name :
            duplicated += '['+ i +']'+ ' Is Duplicated \n'
    print(name)
    print(duplicated)
