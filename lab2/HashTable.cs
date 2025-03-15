using System.Collections;

namespace lab2;

public class MyHashTable
{
    public List<HashTableElement>[] table;

    public MyHashTable(int size)
    {
        table = new List<HashTableElement>[size];
        for (int i = 0; i < table.Length; i++)
            table[i] = new List<HashTableElement>();
    }

    int hashFunction(HashTableElement x)
    {
        return (x.GetHashCode() % table.Length);
    }

    public void InsertItem(HashTableElement element)
    {
        int hashCode = hashFunction(element);
        table[hashCode].Add(element);
    }
    
    public void DeleteItem(HashTableElement element)
    {
        int index = hashFunction(element);
        table[index].Remove(element);
    }

    public void DeleteArea(int area)
    {
        for (int i = 0; i < table.Length; i++)
        {
            var bucket = table[i];
            
            for (int j = 0; j < bucket.Count; j++)
            {
                var element = (Paralelogram) bucket[j];
                if (element.CalculateArea() < area)
                {
                    DeleteItem(element);
                }
                
            }
        }
    }

    public void PrintTable()
    {
        for (int i = 0; i < table.Length; i++)
        {
            Console.Write(i + " --> ");
            int bucketLength = table[i].Count;
            
            if (bucketLength == 0 ) Console.Write("empty");
            for (int j = 0; j < bucketLength; j++)
            {
                var element = table[i][j];
                Console.Write(element);
                if (j != bucketLength-1) 
                    Console.Write(" --> ");
            }
            Console.WriteLine();
        }
    }
}