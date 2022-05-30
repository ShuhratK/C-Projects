using System;
using System.IO;

namespace Praktika_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string output_t = "";

            output_t += "Задание №25 “Матрицы” выполнена Арзяевой Марией\n\n";

            Console.WriteLine("Задание №25 “Матрицы” выполнена Арзяевой Марией");
            Console.WriteLine("Введите m");
            
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());

            Matrix A = new Matrix(3, 15, m, n);
            Matrix B = new Matrix(4, 16, m, n);
            Matrix C = new Matrix(5, 17, m, n);
           

            Matrix C1 = new Matrix(A + B);

            Matrix C2 = new Matrix(A - B);

            Matrix C3 = new Matrix(20 * A - 15 * B);

            Matrix C4 = new Matrix(A * B);

            output_t += log(C1, "C1");
            output_t += "\n";
            output_t += log(C2, "C2");
            output_t += "\n";
            output_t += log(C3, "C3");
            output_t += "\n";
            output_t += log(C4, "C4");
            output_t += "\n";

            Console.Write(output_t);

            Console.WriteLine("Введите имя текстового файла отчёта латинскими буквами: ");
            String output = $@"\{Console.ReadLine()}.txt";

            using (StreamWriter sw = new StreamWriter(output, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(output_t);
            }

            Console.ReadKey();
        }

        public static string log(Matrix C1, string m_name)
        {
            string log = $"{m_name} = \n";

            for (int i = 0; i < C1.rows; i++)
            {
                for (int j = 0; j < C1.columns; j++)
                {
                    log += Convert.ToString(C1.matrix[i, j]);

                    log += " ";
                }
                log += "\n";
            }
            return log;
        }



    }

    class MatrixException : Exception
    {
        public MatrixException(string message) : base(message) { }

    }

    class Matrix
    {
        public int rows { get; private set; }
        public int columns { get; private set; }

        public int[,] matrix;

        public Matrix(int low, int high, int r, int c)
        {
            matrix = new int[r, c];
            rows = r;
            columns = c;
            Random random = new Random();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = random.Next(low, high);
                }
            }
        }

        public Matrix(int r, int c)
        {
            rows = r;
            columns = c;
            matrix = new int[r, c];
        }

        public Matrix(Matrix m)
        {
            rows = m.rows;
            columns = m.columns;

            matrix = m.matrix;
        }

        public static Matrix IdentityMatrix(int r, int c)
        {
            Matrix A = new Matrix(r, c);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (r == c) { A.matrix[i, j] = 1; }
                    else { A.matrix[i, j] = 0; }
                }
            }
            return A;
        }

        

        public static Matrix operator +(Matrix A, Matrix B)
        {
            if (A.rows != B.rows || A.columns != B.columns) throw new MatrixException("Сложение не возможно так как матрицы не соразмерны");


            for (int i = 0; i < A.rows; i++)
            {
                for (int j = 0; j < A.columns; j++)
                {
                    A.matrix[i, j] += B.matrix[i, j];
                }
            }
            return A;
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            if (A.rows != B.rows || A.columns != B.columns) throw new MatrixException("Вычитание не возможно так как матрицы не соразмерны");

            for (int i = 0; i < A.rows; i++)
            {
                for (int j = 0; j < A.columns; j++)
                {
                    A.matrix[i, j] -= B.matrix[i, j];
                }
            }
            return A;
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            if (A.rows != B.columns) throw new MatrixException("Матрицы нельзя перемножить");
            Matrix C = new Matrix(A.rows, B.columns);

            for (int i = 0; i < A.rows; i++)
            {
                for (int j = 0; j < B.columns; j++)
                {
                    for (int k = 0; k < B.rows; k++)
                    {
                        C.matrix[i, j] += A.matrix[i, k] * B.matrix[k, j];
                    }
                }
            }
            return C;
        }

        public static Matrix operator *(Matrix A, int b)
        {
            for (int i = 0; i < A.rows; i++)
            {
                for (int j = 0; j < A.rows; j++)
                {
                    A.matrix[i, j] *= b;
                }
            }
            return A;
        }

        public static Matrix operator *(int b, Matrix A)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    A.matrix[i, j] *= b;
                }
            }
            return A;
        }

        public static Matrix operator +(Matrix A, int b)
        {
            return A + (b * IdentityMatrix(A.rows, A.columns));
        }
        public static Matrix operator +(int b, Matrix A)
        {
            return A + (b * IdentityMatrix(A.rows, A.columns));
        }

        public static Matrix operator -(Matrix A, int b)
        {
            return A - (b * IdentityMatrix(A.rows, A.columns));
        }
        public static Matrix operator -(int b, Matrix A)
        {
            return A - (b * IdentityMatrix(A.rows, A.columns));
        }
    }
}


