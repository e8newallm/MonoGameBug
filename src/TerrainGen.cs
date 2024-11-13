using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace GameMono;

public class Generate
{
    public static Object[,] Gen(int width, int height)
    {
        Object[,] data = new Object[width, height];
        for(int x = 0; x < data.GetLength(0); x++)
        {
            for(int y = 0; y < data.GetLength(1); y++)
            {
                data[x, y] = test;
            }

        }
        return data;
    }

    static object test = new();
}