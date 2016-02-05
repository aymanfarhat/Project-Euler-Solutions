import math

factorial_cache = []

for i in xrange(0, 10):
    factorial_cache.append(math.factorial(i))

upper_limit = math.factorial(9) * 6

def get_digits(num):
    digits = []

    while (num >= 10):
        digit = num % 10
        num = num / 10
        digits.append(digit)

    digits.append(num)

    return digits

def factorial_sum(num_list):
    total = 0

    for num in num_list:
        total += factorial_cache[num]

    return total

curr_num = 0
curious_sum = 0

while (curr_num < upper_limit):
    fac_sum = factorial_sum(get_digits(curr_num))

    if (curr_num == fac_sum):
        curious_sum += curr_num

    curr_num += 1

print curious_sum
