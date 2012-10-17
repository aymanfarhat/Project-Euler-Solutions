import math

def divisorSum(n):
    divSum = 0
    for i in xrange(1,int(math.floor(math.sqrt(n)))+1):
        if(n % i == 0):
            divSum += i
            if(i > 1): divSum += n/i
    return divSum

amicables = []
print "4 : "+str(divisorSum(4))

for n in xrange(1,10000):
    da = divisorSum(n)
    db = divisorSum(da)
    
    if(db == n and n != da and n not in amicables):
        amicables.append(n)
        amicables.append(da)

print sum(amicables)
