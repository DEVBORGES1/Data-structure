using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public enum TerrainEnum
{
    Grama, Areia, Agua, Parede
}

public static class TerrainEnumExtensions
{
 public static ConsoleColor GetColor(this TerrainEnum terrain)
 {
 switch (terrain)
 {
 case TerrainEnum.Grama: return ConsoleColor.Green;
 case TerrainEnum.Areia: return ConsoleColor.Yellow;
 case TerrainEnum.Agua: return ConsoleColor.Blue;
 default: return ConsoleColor.DarkGray;
 }
 }
 public static char GetChar(this TerrainEnum terrain)
 {
 switch (terrain)
 {
 case TerrainEnum.Grama: return '\u201c';
 case TerrainEnum.Areia: return '\u25cb';
 case TerrainEnum.Agua: return '\u2248';
 default: return '\u25cf';
 }
 }
}