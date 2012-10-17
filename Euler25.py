""" Recursive Fibonacci sequence with dictionary to cache previous results
    in order to reduce the number of repetitive computations and execution time """

store = {0:0,1:1}

def fibo(n):
    if n not in store:
        store[n] = fibo(n-1) + fibo(n-2)
    return store[n]

i = 0
fibVal = 0

while(len(str(fibVal)) < 1000):
    fibVal = fibo(i)
    print str(i)+" : "+str(fibVal)
    i += 1

print "First term to contain 1000 digits = "+str(i-1)
