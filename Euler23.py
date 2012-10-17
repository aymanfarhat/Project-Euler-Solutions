import math

def divisorSum(n):
    divSum = []
    for i in xrange(1,int(math.floor(math.sqrt(n))+1)):
        if (n % i == 0):
            if i not in divSum: divSum.append(i)
            if i > 1 and n/i not in divSum: divSum.append(n/i)
    
    return sum(divSum)

abundants = [n for n in xrange(28124) if divisorSum(n) > n]
pairSums = [False]*28125
unabSum = 0

for i in xrange(0,len(abundants)):
    for j in xrange(i,len(abundants)):
        if(abundants[i] + abundants[j] <= 28124):
            pairSums[abundants[i] + abundants[j]] = True
        else: break
        
for n in xrange(28125):
    if(pairSums[n] == False):
        unabSum += n
        
print unabSum