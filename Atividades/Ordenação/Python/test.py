from Ordenações import QuickSort
import random

rNumbers = random.sample(range(1,1000), 42)

sorted = [1, 2, 3, 4, 5, 6, 9, 20, 22, 23, 28, 32, 34, 39, 40, 42, 76, 87, 99, 112]

inversed = [117, 90, 88, 83, 77, 74, 69, 64, 63, 51, 50, 49, 42, 41, 34, 32, 29, 28, 22, 16, 8, 6, 5]

repeat = [7, 4, 3, 2, 1, 4, 7, 2, 3, 1, 3, 3, 7, 7, 2, 1, 2]

if __name__ == "__main__":
    testCases = {'Números aleatórios': rNumbers,
                    'Ordenados': sorted,
                    'Invertidos': inversed,
                    'Repetidos': repeat
                    }
    print("=-"*30)
    for name, lista in testCases.items():
        print(f"\nCaso do teste: {name}")
        print(lista)
        QuickSort.quicksort(lista)
        print("\nOrdenado: ")
        print(lista)
    print("=-"*30)
