# Функциональный вариант
def sum_n(n):
    if n == 0 or n == 1:
        return n
    return n + sum_n(n-1)

def sum_numbers(numbers):
    if (len(numbers) == 0):
        return 0
    return numbers[0] + sum_numbers(numbers[1:])

def check_numbers_functional(numbers):
    return sum_n(len(numbers)+1) - sum_numbers(numbers)

# Императивный вариант
def check_numbers_imperative(numbers):
    full_sum = 0
    for i in range(1, len(numbers)+2):
        full_sum += i
    numbers_sum = 0
    for i in numbers:
        numbers_sum += i
    return full_sum - numbers_sum

print("Функциональный вариант:")
print(check_numbers_functional([1, 2, 3, 5]))

print("Императивный вариант:")
print(check_numbers_imperative([1, 2, 3, 5]))