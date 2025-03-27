
using System.Collections;
using lab2;

public class Examples
{
    static public void Level1()
    {
        var v1 = new Vector {x = 1, y = 2};
        var v2 = new Vector {x = 4, y = 5};
        var v3 = new Vector {x = 6, y = 3};
        var v4 = new Vector {x = 3, y = 0};

        var v11 = new Vector { x = 1, y = 2 };
        var v12 = new Vector { x = 5, y = 2 };
        var v13 = new Vector { x = 6, y = 5 };
        var v14 = new Vector { x = 2, y = 5 };

        var v21 = new Vector { x = 0, y = 0 };
        var v22 = new Vector { x = 4, y = 3 };
        var v23 = new Vector { x = 7, y = 3 };
        var v24 = new Vector { x = 3, y = 0 };

        var v31 = new Vector { x = -2, y = 1 };
        var v32 = new Vector { x = 3, y = 4 };
        var v33 = new Vector { x = 6, y = 2 };
        var v34 = new Vector { x = 1, y = -1 };


        var paralelogram1 = new Paralelogram(v1, v2, v3, v4);
        var paralelogram2 = new Paralelogram(v11, v12, v13, v14);
        var paralelogram3 = new Paralelogram(v21, v22, v23, v24);
        var paralelogram4 = new Paralelogram(v31, v32, v33, v34);

        var hashTable = new MyHashTable(10);

        // add element
        hashTable.InsertItem(paralelogram1);
        hashTable.InsertItem(paralelogram2);
        hashTable.InsertItem(paralelogram3);
        hashTable.InsertItem(paralelogram4);

        // get element
        hashTable.PrintTable();
    }

    static public void Level2()
    {
        var v1 = new Vector {x = 1, y = 2};
        var v2 = new Vector {x = 4, y = 5};
        var v3 = new Vector {x = 6, y = 3};
        var v4 = new Vector {x = 3, y = 0};

        var v11 = new Vector { x = 1, y = 2 };
        var v12 = new Vector { x = 5, y = 2 };
        var v13 = new Vector { x = 6, y = 5 };
        var v14 = new Vector { x = 2, y = 5 };

        var v21 = new Vector { x = -1, y = 0 };
        var v22 = new Vector { x = 3, y = 3 };
        var v23 = new Vector { x = 6, y = 3 };
        var v24 = new Vector { x = 2, y = 0 };

       
        var v31 = new Vector { x = 0, y = 0 };
        var v32 = new Vector { x = 4, y = 3 };
        var v33 = new Vector { x = 7, y = 3 };
        var v34 = new Vector { x = 3, y = 0 };


        var paralelogram1 = new Paralelogram(v1, v2, v3, v4);
        var paralelogram2 = new Paralelogram(v11, v12, v13, v14);
        var paralelogram3 = new Paralelogram(v21, v22, v23, v24);
        var paralelogram4 = new Paralelogram(v31, v32, v33, v34);

        var hashTable = new MyHashTable(10);

        // add element
        hashTable.InsertItem(paralelogram1);
        hashTable.InsertItem(paralelogram2);
        hashTable.InsertItem(paralelogram3);
        hashTable.InsertItem(paralelogram4);

        // get element
        hashTable.PrintTable();
    }

    static public void Level3()
    {
        var v1 = new Vector {x = 1, y = 2};
        var v2 = new Vector {x = 4, y = 5};
        var v3 = new Vector {x = 6, y = 3};
        var v4 = new Vector {x = 3, y = 0};

        var v11 = new Vector { x = 1, y = 2 };
        var v12 = new Vector { x = 5, y = 2 };
        var v13 = new Vector { x = 6, y = 5 };
        var v14 = new Vector { x = 2, y = 5 };

        var v21 = new Vector { x = 0, y = 0 };
        var v22 = new Vector { x = 4, y = 3 };
        var v23 = new Vector { x = 7, y = 3 };
        var v24 = new Vector { x = 3, y = 0 };

       
        var v31 = new Vector { x = 0, y = 0 };
        var v32 = new Vector { x = 4, y = 3 };
        var v33 = new Vector { x = 7, y = 3 };
        var v34 = new Vector { x = 3, y = 0 };
        
        var v41 = new Vector { x = 0, y = 0 };
        var v42 = new Vector { x = 15, y = 0 };
        var v43 = new Vector { x = 5, y = 12 };
        var v44 = new Vector { x = -10, y = 12 };


        var paralelogram1 = new Paralelogram(v1, v2, v3, v4);
        var paralelogram2 = new Paralelogram(v11, v12, v13, v14);
        var paralelogram3 = new Paralelogram(v21, v22, v23, v24);
        var paralelogram4 = new Paralelogram(v31, v32, v33, v34);
        var paralelogram5 = new Paralelogram(v41, v42, v43, v44);

        var hashTable = new MyHashTable(10);

        // add element
        hashTable.InsertItem(paralelogram1);
        hashTable.InsertItem(paralelogram2);
        hashTable.InsertItem(paralelogram3);
        hashTable.InsertItem(paralelogram4);
        hashTable.InsertItem(paralelogram5);

        // print table
        hashTable.PrintTable();
        
        //remove element
        DeleteArea(hashTable, 100);
        
        // print table
        Console.WriteLine("Updated table");
        hashTable.PrintTable();

    }
    
    static void DeleteArea(MyHashTable table, int area)
    {
        foreach (var bucket in table.table)
        {
            bucket.RemoveAll(element => element is Paralelogram paralelogram && paralelogram.CalculateArea() < area);
        }
    }
}