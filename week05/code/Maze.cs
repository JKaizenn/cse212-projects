using System;
using System.Collections.Generic;

public class Maze
{
    public int Width { get; }
    public int Height { get; }

    public readonly int[] Data;

    public Maze(int width, int height, int[] data)
    {
        if (data.Length != width * height)
        {
            throw new ArgumentException("Data length must match the dimensions of the maze.");
        }

        this.Width = width;
        this.Height = height;
        this.Data = data;
    }

    /// <summary>
    /// Helper function to determine if the (x,y) position is at 
    /// the end of the maze.
    /// </summary>
    public bool IsEnd(int x, int y)
    {
        return Data[y * Width + x] == 2;
    }

    /// <summary>
    /// Helper function to determine if the (x,y) position is a valid
    /// place to move given the size of the maze, the content of the maze,
    /// and the current path already traversed.
    /// </summary>
    public bool IsValidMove(List<ValueTuple<int, int>> currPath, int x, int y)
    {
        // Can't go outside of the maze boundary
        if (x < 0 || x >= Width || y < 0 || y >= Height)
            return false;
        // Can't go through a wall
        if (Data[y * Width + x] == 0)
            return false;
        // Can't go if we have already been there (don't go in circles)
        if (currPath.Contains((x, y)))
            return false;
        // Otherwise, we are good
        return true;
    }
}
