F = [int(x) for x in input("Please Enter The Numbers And Split It With Space \n").split()]


def Selection_Sort(A):
    for i in range (0,len(A)-1) :
        MinIndex = i
        for j in range (i+1,len(A)) :
            if A[j] < A[MinIndex] :
                MinIndex = j
        if MinIndex != i :
            A[i] , A[MinIndex] = A[MinIndex] , A[i]



Selection_Sort(F)


print(F)
