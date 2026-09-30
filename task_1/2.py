# Функциональный вариант
def make_magical_number_functional(n):
    if n <= 0:
        return
    if n == 1:
        return [n]
    if n%2 == 0:
        return [n] + make_magical_number_functional(n//2)
    return [n] + make_magical_number_functional(3*n + 1)

# Императивный вариант
def make_magical_number_imperative(n):
    if n <= 0:
        return
    result = []
    while n > 1:
        result.append(n)
        if n%2 == 0:
            n = n//2
        else:
            n = 3*n + 1
    result.append(1)
    return result

print("Функциональный вариант:")
for i in make_magical_number_functional(5):
    print(i, end = " ")
print()

print("Императивный вариант:")
for i in make_magical_number_imperative(5):
    print(i, end = " ")
print()