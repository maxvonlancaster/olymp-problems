import random

list = ["Vasyl", "Borys", "Denys", "Vasylyna", "Tetiana", "Iryna"]
i = random.randint(0, len(list) - 1)
print(list.pop(i))