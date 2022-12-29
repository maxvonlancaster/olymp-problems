import math 

def get_squeres(i):
    res = 0
    splits = str(i).split()
    for s in splits:
        res += int(s)* int(s)
    return res

def calculate_squeres(i):
    list_unique = []
    a = i
    while True:
        list_unique.append(a)
        a = get_squeres(a)
        if a in list_unique:
            break
    return a

for i in range(1, 100):
    res = calculate_squeres(i)
    print(f'{i} : {res} \n')