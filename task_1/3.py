# Функциональный вариант
def make_cells_functional(numbers):
    if len(numbers) < 1:
        return []
    return ["#"*numbers[0]] + make_cells_functional(numbers[1:])

# Императивный вариант
def make_cells_imperative(numbers):
    result = []
    for number in numbers:
        result.append("#"*number)
    return result

numbers = []
while True:
    value = input()
    if value == "":
        break
    numbers.append(int(value))

cells_functional = make_cells_functional(numbers)
cells_imperative = make_cells_imperative(numbers)

print("Функциональный вариант:")
for cell in cells_functional:
    print(cell)

print("Императивный вариант:")
for cell in cells_imperative:
    print(cell)