""" Find the last ten digits of the series, 11 + 22 + 33 + ... + 1000^1000 """

series_sum = 0

for a in xrange(1,1000):
		series_sum += a**a

print str(series_sum)[-10:]

