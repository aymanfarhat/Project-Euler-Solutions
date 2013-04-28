import urllib2

# Dictionary of alphabets and their respective scores
alpha_ref = dict(zip(map(chr,range(65,91)),range(1,27)))

inp_str = urllib2.urlopen("http://projecteuler.net/project/names.txt").read()

names_list = map(lambda s: s[1:len(s)-1],inp_str.split(","))

names_list.sort()

name_val = lambda s: sum([alpha_ref[x] for x in s])

total = 0
for rank in xrange(1,len(names_list)+1):
	total += rank * name_val(names_list[rank-1])

print total



