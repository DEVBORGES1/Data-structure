TerrainEnum[,] map =
{
 { TerrainEnum.Areia, TerrainEnum.Areia, TerrainEnum.Areia,
 TerrainEnum.Areia, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama },
  
{ TerrainEnum.Areia, TerrainEnum.Areia, TerrainEnum.Areia,
 TerrainEnum.Areia, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama },

{ TerrainEnum.Areia, TerrainEnum.Areia, TerrainEnum.Areia,
 TerrainEnum.Areia, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama },

{ TerrainEnum.Areia, TerrainEnum.Areia, TerrainEnum.Areia,
 TerrainEnum.Areia, TerrainEnum.Parede, TerrainEnum.Parede,
 TerrainEnum.Parede, TerrainEnum.Parede, TerrainEnum.Parede,
 TerrainEnum.Parede },

{ TerrainEnum.Agua, TerrainEnum.Agua, TerrainEnum.Agua,
 TerrainEnum.Agua, TerrainEnum.Agua, TerrainEnum.Agua,
 TerrainEnum.Agua, TerrainEnum.Agua, TerrainEnum.Agua,
 TerrainEnum.Agua },
  
 { TerrainEnum.Agua, TerrainEnum.Agua, TerrainEnum.Agua,
 TerrainEnum.Agua, TerrainEnum.Agua, TerrainEnum.Agua,
 TerrainEnum.Agua, TerrainEnum.Agua, TerrainEnum.Agua,
 TerrainEnum.Agua },
  
{ TerrainEnum.Areia, TerrainEnum.Areia, TerrainEnum.Areia,
 TerrainEnum.Areia, TerrainEnum.Parede, TerrainEnum.Parede,
 TerrainEnum.Parede, TerrainEnum.Parede, TerrainEnum.Parede,
 TerrainEnum.Parede },

{ TerrainEnum.Areia, TerrainEnum.Areia, TerrainEnum.Areia,
 TerrainEnum.Areia, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama },
  
{ TerrainEnum.Areia, TerrainEnum.Areia, TerrainEnum.Areia,
 TerrainEnum.Areia, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama },

 { TerrainEnum.Areia, TerrainEnum.Areia, TerrainEnum.Areia,
 TerrainEnum.Areia, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama },
 
 { TerrainEnum.Areia, TerrainEnum.Areia, TerrainEnum.Areia,
 TerrainEnum.Areia, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama, TerrainEnum.Grama, TerrainEnum.Grama,
 TerrainEnum.Grama },

};
Console.OutputEncoding = System.Text.Encoding.UTF8;
for (int row = 0; row < map.GetLength(0); row++)
{
 for (int column = 0; column < map.GetLength(1); column++)
 {
 Console.ForegroundColor = map[row, column].GetColor();
 Console.Write(map[row, column].GetChar() + " ");
 }
 Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Gray;