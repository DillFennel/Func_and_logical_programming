# Функциональный вариант
def check_numbers_functional(numbers, max_identical = 0, max_identical_val = 0, prev_identical = 1):
    if len(numbers) == 0:
        return 0
    if len(numbers) == 1:
        if max_identical >= prev_identical:
            return max_identical_val
        return numbers[0]
    if numbers[0] == numbers[1]:
        return check_numbers_functional(numbers[1:], max_identical, max_identical_val, prev_identical + 1)
    if max_identical >= prev_identical:
        return check_numbers_functional(numbers[1:], max_identical, max_identical_val, 1)
    return check_numbers_functional(numbers[1:], prev_identical, numbers[0], 1)

# Императивный вариант
def check_numbers_imperative(numbers):
    if not numbers:
        return 0
    max_identical = 0
    max_identical_val = 0
    prev_identical = 1
    for i in range(len(numbers)):
        if i == 0:
            continue
        if numbers[i] == numbers[i-1]:
            prev_identical += 1
        else:
            if max_identical < prev_identical:
                max_identical = prev_identical
                max_identical_val = numbers[i-1]
            prev_identical = 1
    if max_identical < prev_identical:
        max_identical = prev_identical
        max_identical_val = numbers[-1]
        return max_identical_val
    return max_identical_val

print("Функциональный вариант:")
print(check_numbers_functional([1, 2, 3, 4, 5])) # 1
print(check_numbers_functional([1, 2, 3, 4, 5, 5])) # 5
print(check_numbers_functional([1, 2, 3, 3, 3, 4, 5, 5])) # 3
print(check_numbers_functional([1, 1, 1, 1, 2, 3, 5, 5, 5, 5])) #1

print("Императивный вариант:")
print(check_numbers_imperative([1, 2, 3, 4, 5])) # 1
print(check_numbers_imperative([1, 2, 3, 4, 5, 5])) # 5
print(check_numbers_imperative([1, 2, 3, 3, 3, 4, 5, 5])) # 3
print(check_numbers_imperative([1, 1, 1, 1, 2, 3, 5, 5, 5, 5])) #1