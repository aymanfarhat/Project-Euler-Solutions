""" Starting with 1 predefined. Think of diagonal elements as square corners of four for each circulation
between each of the elements, increases by 2 for each cycle of four, thus we can come up with a 
series """

diagonals = [1]
diff = 2
i = 3
elements = 1001 * 1001

while i < (elements):
    for x in xrange(0,4):
        diagonals.append(i)
        if x < 3:
            i += diff

    diff += 2
    i += diff
    
print sum(diagonals)
