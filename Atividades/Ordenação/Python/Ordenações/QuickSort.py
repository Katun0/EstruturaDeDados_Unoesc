def quicksort(roster, start=0, stop=None):
    
    if stop == None:
        stop = len(roster)-1

    if start < stop:
        pi = partition(roster, start, stop)
        quicksort(roster, start, pi-1)
        quicksort(roster, pi+1, stop)



def partition(roster, start, stop):
    pivot = roster[stop]
    i = start
    for j in range(start, stop):
        if roster[j] >= pivot:
            roster[j], roster[i] = roster[i], roster[j]
            i += 1
    
    roster[i], roster[stop] = roster[stop], roster[i]
    return i