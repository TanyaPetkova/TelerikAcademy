namespace ArithmeticOperationsOnMatrices
{
    using System;

    public class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        private void ValidateIndex(int row, int col)
        {
            if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }
        }

        private static void ValidateSize(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("Both matrices have different sizes.");
            }
        }

        public T this[int row, int col]
        {
            get
            {
                ValidateIndex(row, col);

                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    result += this.matrix[i, j] + "\t";
                }

                result += "\n";
            }

            return result.Trim();
        }

        public static Matrix<T> operator +(Matrix<T> firstAddend, Matrix<T> secondAddend)
        {
            Matrix<T> result = new Matrix<T>(firstAddend.Rows, firstAddend.Cols);

            ValidateSize(firstAddend, secondAddend);

            for (int i = 0; i < firstAddend.Rows; i++)
            {
                for (int j = 0; j < firstAddend.Cols; j++)
                {
                    result[i, j] = (dynamic)firstAddend[i, j] + (dynamic)secondAddend[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> minuend, Matrix<T> subtrahend)
        {
            Matrix<T> result = new Matrix<T>(minuend.Rows, minuend.Cols);

            ValidateSize(minuend, subtrahend);

            for (int i = 0; i < minuend.Rows; i++)
            {
                for (int j = 0; j < minuend.Cols; j++)
                {
                    result[i, j] = (dynamic)minuend[i, j] - (dynamic)subtrahend[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMultiplier, Matrix<T> secondMultiplier)
        {
            Matrix<T> result = new Matrix<T>(firstMultiplier.Rows, secondMultiplier.Cols);

            if (firstMultiplier.Cols != secondMultiplier.Rows)
            {
                throw new ArgumentException("The condition for multiplication of two matrices is not satisfied.");
            }

            for (int i = 0; i < firstMultiplier.Rows; i++)
            {
                for (int j = 0; j < secondMultiplier.Cols; j++)
                {
                    for (int k = 0; k < firstMultiplier.Cols; k++)
                    {
                        result[i, j] += (dynamic)firstMultiplier[i, k] * (dynamic)secondMultiplier[k, j];
                    }
                }
            }

            return result;
        }

        private static bool BoolOperator(Matrix<T> matrix, bool boolValue)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (!matrix[i, j].Equals(0))
                    {
                        return boolValue;
                    }
                }
            }

            return !boolValue;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return BoolOperator(matrix, true);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return BoolOperator(matrix, false);
        }
    }
}
