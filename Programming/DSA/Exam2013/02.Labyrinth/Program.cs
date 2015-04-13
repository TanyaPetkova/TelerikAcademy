namespace Labyrinth
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] startPosition = Console.ReadLine().Split(' ');
            Cell<int> startCell = new Cell<int>(
                int.Parse(startPosition[0]),
                int.Parse(startPosition[1]),
                int.Parse(startPosition[2]),
                0);

            string[] dimensions = Console.ReadLine().Split(' ');
            int l = int.Parse(dimensions[0]);
            int r = int.Parse(dimensions[1]);
            int c = int.Parse(dimensions[2]);

            char[, ,] labyrinth = new char[l, r, c];
            var used = new HashSet<Cell<int>>();
            for (int x = 0; x < l; x++)
            {
                for (int y = 0; y < r; y++)
                {
                    string currentLine = Console.ReadLine();
                    for (int z = 0; z < c; z++)
                    {
                        labyrinth[x, y, z] = currentLine[z];
                        if (labyrinth[x, y, z] == '#')
                        {
                            used.Add(new Cell<int>(x, y, z, -1));
                        }
                    }
                }
            }

            Queue<Cell<int>> queue = new Queue<Cell<int>>();
            queue.Enqueue(startCell);
            used.Add(startCell);

            while (queue.Count > 0)
            {
                var cell = queue.Dequeue();

                //Left
                if (cell.Column > 0)
                {
                    var newCell = new Cell<int>(cell.Level, cell.Row, cell.Column - 1, cell.QueueLevel + 1);
                    if (!used.Contains(newCell))
                    {
                        queue.Enqueue(newCell);
                        used.Add(newCell);
                    }
                }

                //Right
                if (cell.Column < c - 1)
                {
                    var newCell = new Cell<int>(cell.Level, cell.Row, cell.Column + 1, cell.QueueLevel + 1);
                    if (!used.Contains(newCell))
                    {
                        queue.Enqueue(newCell);
                        used.Add(newCell);
                    }
                }

                //Forward
                if (cell.Row > 0)
                {
                    var newCell = new Cell<int>(cell.Level, cell.Row - 1, cell.Column, cell.QueueLevel + 1);
                    if (!used.Contains(newCell))
                    {
                        queue.Enqueue(newCell);
                        used.Add(newCell);
                    }
                }

                //Backward
                if (cell.Row < r - 1)
                {
                    var newCell = new Cell<int>(cell.Level, cell.Row + 1, cell.Column, cell.QueueLevel + 1);
                    if (!used.Contains(newCell))
                    {
                        queue.Enqueue(newCell);
                        used.Add(newCell);
                    }
                }

                //Up
                if (labyrinth[cell.Level, cell.Row, cell.Column] == 'U')
                {
                    if (cell.Level == l - 1)
                    {
                        Console.WriteLine(cell.QueueLevel + 1);
                        return;
                    }
                    else
                    {
                        var newCell = new Cell<int>(cell.Level + 1, cell.Row, cell.Column, cell.QueueLevel + 1);
                        if (!used.Contains(newCell))
                        {
                            queue.Enqueue(newCell);
                            used.Add(newCell);
                        }
                    }
                }

                //Down
                if (labyrinth[cell.Level, cell.Row, cell.Column] == 'D')
                {
                    if (cell.Level == 0)
                    {
                        Console.WriteLine(cell.QueueLevel + 1);
                        return;
                    }
                    else
                    {
                        var newCell = new Cell<int>(cell.Level - 1, cell.Row, cell.Column, cell.QueueLevel + 1);
                        if (!used.Contains(newCell))
                        {
                            queue.Enqueue(newCell);
                            used.Add(newCell);
                        }
                    }
                }
            }
        }
    }

    public class Cell<T>
    {
        public Cell(T level, T row, T column, int queueLevel)
        {
            this.Level = level;
            this.Row = row;
            this.Column = column;
            this.QueueLevel = queueLevel;
        }

        public T Level { get; set; }

        public T Row { get; set; }

        public T Column { get; set; }

        public int QueueLevel { get; set; }

        public override bool Equals(object obj)
        {
            var otherCell = obj as Cell<T>;
            if (otherCell == null)
            {
                return false;
            }

            return this.Level.Equals(otherCell.Level)
                && this.Row.Equals(otherCell.Row)
                && this.Column.Equals(otherCell.Column);
        }

        public override int GetHashCode()
        {
            return this.Level.GetHashCode()
                ^ this.Row.GetHashCode()
                ^ this.Column.GetHashCode();
        }
    }
}
