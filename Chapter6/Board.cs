namespace Chapter6;

// public class Board
// {
//     private int Width { get; }
//     private int Height { get; }
//     private char[,] GameBoard { get; }
//     private Tile[,] Tiles { get; }
//     
//     private class Tile
//     {
//         public int Units { get; set; }
//     }
//
//
//    public Board(int width, int height)
//       {
//           Width = width;
//           Height = height;
//           GameBoard = new char[height, width]; 
//           Tiles = new Tile[height, width];
//       
//           for(var i = 0; i < height; ++i)
//           {
//               for (var j = 0; j < width; ++j)
//               {
//                   Tiles[i, j] = new Tile();
//               }
//           }
//       
//           InitializeBoard();
//       }
//
//     private void InitializeBoard()
//     {
//         for (var row = 0; row < Height; row++)
//         {
//             for (var column = 0; column < Width; column++)
//             {
//                 GameBoard[row, column] = '■'; 
//             }
//         }
//     }
//
//     public void PrintBoard()
//     {
//         for (var row = 0; row < Height; row++)
//         {
//             for (var column = 0; column < Width; column++)
//             {
//                 Console.Write(GameBoard[row, column] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
//     
//     public char GetTileAtPosition(int x, int y)
//     {
//         if (x >= 0 && x < Width && y >= 0 && y < Height)
//         {
//             return GameBoard[y, x];
//         }
//         return '\0';
//     }
//     
//     public void AddUnitsToTile(int x, int y, int unitsToAdd)
//     {
//         if (x >= 0 && x < Width && y >= 0 && y < Height)
//         {
//             var targetTile = Tiles[y, x];
//
//             targetTile.Units += unitsToAdd;
//         }
//         else
//         {
//             Console.WriteLine("Invalid position: (" + x + ", " + y + ")");
//         }
//     }
//     
//     public int GetAllUnitsAtTile(int x, int y)
//     {
//         if (x >= 0 && x < Width && y >= 0 && y < Height)
//         {
//             var targetTile = Tiles[y, x];
//             return targetTile.Units;
//         }
//         Console.WriteLine("Invalid position: (" + x + ", " + y + ")");
//         return -1;
//     }
// }