# Функциональный вариант
def reverse_string_functional(s):
    if (len(s) < 1):
        return ""
    if (len(s) == 1):
        return s
    return s[-1] + reverse_string_functional(s[:-1])

# Императивный вариант
def reverse_string_imperative(s):
    result = ""
    for char in s:
        result = char + result
    return result

print("Функциональный вариант:")
print(reverse_string_functional("hello!"))

print("Императивный вариант:")
print(reverse_string_imperative("hello!"))
