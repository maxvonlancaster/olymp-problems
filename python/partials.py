max_part = 0
i = 10
list = [2,3,4,5,7]
list_part = []
# for i in range(len(list)):
while list:
    maxx = max(list)
    minn = min(list)
    list.remove(maxx)
    list.remove(minn)
    if max_part < maxx/minn:
        max_part = maxx/minn 

