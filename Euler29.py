range = (2, 100)
terms = {}
for a in xrange(range[0], range[1]+1):
    for b in xrange(range[0], range[1]+1):
        val = a**b
        if val not in terms:
            terms[val] = True

print len(terms.keys())
