// Турнирная таблица

Console.WriteLine("Чемпионат Гадюкинского Района");
Console.WriteLine();

string[,] table = new string[6, 6];

PrintNames(table);
FillChart(table);
CountScore(table);

void PrintNames(string[,] table)
{
table[0, 1] = table[1, 0] = "Пацан    ";
table[0, 2] = table[2, 0] = "Кардан   ";
table[0, 3] = table[3, 0] = "Чабан    ";
table[0, 4] = table[4, 0] = "Банан    ";
table[0, 5] = table[5, 0] = "Баклан   ";
}

void FillChart(string[,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
{    for (int j = 0; j < table.GetLength(1); j++)
    {
        if (i == j) 
        {
            table[i, j] = "---------";
        }
        else 
        if (i != j && i > 0 && j > 0)
        {
            string[] scores = {"выигрыш", "проигрыш", "ничья   "};
            Random rnd = new Random();
            int index = rnd.Next(0, scores.Length);
            table[i, j] = Convert.ToString(scores[index]);
            
        }
        Console.Write(table[i,j] + "  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
}

void CountScore(string[,] table)
{
    Console.WriteLine();

    int[] count1 = new int[6];
    int[] count2 = new int[6];
    for (int i = 1; i < table.GetLength(0); i++)
    {
        
        for (int j = 1; j < table.GetLength(1); j++)
        {
            
            if (table[i, j] == "выигрыш") count1[i] += 3;
            else
            {
                if (table[i, j] == "ничья   ") count1[i] += 1;
            }
        }
        
    }

    for (int j = 1; j < table.GetLength(0); j++)
    {
        for (int i = 1; i < table.GetLength(1); i++)
        {
            if (table[i, j] == "выигрыш") count2[j] += 3;
            else
            {
                if (table[i, j] == "ничья   ") count2[j] += 1;
            }
        }
    }
    Console.WriteLine ("Итоги чемпионата:");
    
    for (int i = 1; i < table.GetLength(0); i++)
    {
        int[] result = new int[6];
        result[i] = (count1[i] + count2[i]);
    
        
        Console.WriteLine(table[i,0] + result[i]);
    }

        
}
