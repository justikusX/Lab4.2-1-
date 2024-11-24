
int[,] matrix = {
    {3, 5, 2, 1},
    {1, 3, 5, 2},
    {4, 2, 5, 6},
    {2, 1, 3, 5}
};

int M = matrix.GetLength(0);
int N = matrix.GetLength(1);

HashSet<int> RowSet = new HashSet<int>();

for (int j = 0; j < N; j++)
{
    RowSet.Add(matrix[0, j]);
}

int Count = 0;


for (int i = 1; i < M; i++)
{
    HashSet<int> Set = new HashSet<int>();
    for (int j = 0; j < N; j++)
    {
        Set.Add(matrix[i, j]);
    }


    if (RowSet.SetEquals(Set))
    {
        Count++;
    }
}

Console.WriteLine("Количество строк, похожих на первую строку: " + Count);
