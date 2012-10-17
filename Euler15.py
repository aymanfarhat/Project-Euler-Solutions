m = n = 20 # A 20x20 grid would have 21x21 nodes

# Initialize an empty grid of nodes
nodesGrid = [[0 for x in xrange(m+1)] for x in xrange(n+1)]

"""
Iterate through each cell and create Pascal's triangle along the way where the value of each cell(number of routes to reach it)
at i,j is grid(i-1,j) + grid((i,j-1)) if the cell is on left or top edge of the grid it value is 1
"""

for i in (xrange(m+1)):
    for j in (xrange(n+1)):
        if (i == 0 or j == 0):
            nodesGrid[i][j] = 1

        else:
            nodesGrid[i][j] = nodesGrid[i-1][j] + nodesGrid[i][j-1]

# Total number of routes is the value of the last cell at 20,20
print nodesGrid[m][n]
