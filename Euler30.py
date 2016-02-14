power_cache = {x: x ** 5 for x in xrange(0, 10)}

def get_digits(num):
    digits = []

    while (num >= 10):
        digit = num % 10
        num = num / 10
        digits.append(digit)

    digits.append(num)

    return digits


def sum_digit_powers(num_list):
    total = 0

    for num in num_list:
        total += power_cache[num]

    return total


final_sum = 0
upper_limit = 6 * (9 ** 5)

for i in xrange(2, upper_limit):
    if i == sum_digit_powers(get_digits(i)):
        final_sum += i

print final_sum
