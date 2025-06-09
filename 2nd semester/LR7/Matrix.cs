using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LR7
{
    internal class Matrix
    {
        private int[,] matrix = new int[2, 2];

        public Matrix()
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    matrix[i, j] = 0;
        }
        public Matrix(int a00, int a01, int a10, int a11)
        {
            matrix[0, 0] = a00;
            matrix[0, 1] = a01;
            matrix[1, 0] = a10;
            matrix[1, 1] = a11;
        }
        public Matrix(int[,] matrix)
        {
            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
                throw new ArgumentException("Expected 2x2 array");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    this.matrix[i, j] = matrix[i, j];
        }
        public Matrix(Matrix OtherMatrix)
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    this.matrix[i, j] = OtherMatrix.matrix[i, j];
        }

        public int this[int row, int col]
        {
            get
            {
                if (row < 0 || col < 0 || row > 1 || col > 1)
                    throw new IndexOutOfRangeException("Expected index for 2x2 array");
                return matrix[row, col];
            }
            set
            {
                if (row < 0 || col < 0 || row > 1 || col > 1)
                    throw new IndexOutOfRangeException("Expected index for 2x2 array");
                matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            return $"\n {matrix[0, 0]}, {matrix[0, 1]}" +
                   $"\n {matrix[1, 0]}, {matrix[1, 1]}";
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            int[,] C = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    C[i, j] = A[i, j] + B[i, j];
            return new Matrix(C);
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            int[,] C = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    C[i, j] = A[i, j] - B[i, j];
            return new Matrix(C);
        }

        public static Matrix operator ++(Matrix A)
        {
            int[,] c = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    ++A[i, j];
            return A;
        }

        public static Matrix operator --(Matrix A)
        {
            int[,] c = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    --A[i, j];
            return A;
        }

        public static Matrix operator *(Matrix A, int num)
        {
            int[,] C = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    C[i, j] = A[i, j] * num;
            return new Matrix(C);
        }

        public static Matrix operator /(Matrix A, int num)
        {
            if (num == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            int[,] C = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    C[i, j] = A[i, j] / num;
            return new Matrix(C);
        }

        public static bool operator ==(Matrix A, Matrix B)
        {
            int[,] C = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    if (A[i, j] != B[i, j])
                        return false;
            return true;
        }
        public static bool operator !=(Matrix A, Matrix B)
        {
            int[,] C = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    if (A[i, j] != B[i, j])
                        return true;
            return false;
        }

        public static bool operator true(Matrix A)
            => A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0] != 0;
        public static bool operator false(Matrix A)
             => A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0] == 0;

        public static explicit operator int(Matrix A)
             => A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
        public static explicit operator Matrix(int a)
             => new Matrix(a, 0, 0, a);
    }
}
