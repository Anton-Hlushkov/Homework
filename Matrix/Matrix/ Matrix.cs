using System;
namespace Matrix
{
    public class Matrix <T>
    {
		int size;
		T *[]row = new T [size];
		T []columns = new T [size];
		public Matrix(int a, T*[]b)
		{
			size = a;
			columns = b;

		}
    }
}
