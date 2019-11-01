using System;
using System.Collections.Generic;

public class HashMapAdapter<K> : Dictionary<int?, int?>
{
    public HashMapAdapter(int?[][] matrix) : base()
    {
        if (matrix == null)
        {
            throw new NullReferenceException("Matriz não pode ser nula");
        }

        if (matrix.Length != 2)
        {
            throw new ArgumentException("Matriz não tem duas linhas");
        }

        if (matrix[0].Length != matrix[1].Length)
        {
            throw new ArgumentException("Linhas de comprimento são diferentes");
        }

        for (int column = 0; column < matrix[0].Length; column++)
        {
            this.Add(matrix[0][column], matrix[1][column]);
        }
    }
}
