Console.Clear();
 
int numero1;
int numero2;
int aux;
 
do
{
    if (numeroUm != Int32.MinValue || numeroDois != Int32.MaxValue)
    {
        Console.Clear();
        Console.WriteLine($"O fim ({numeroDois}) não pode ser menor que o inicio ({numeroUm})");
        Console.WriteLine();
    }
    
    Console.Write("Primeiro número: ");
    Int32.TryParse(Console.ReadLine()!, out numero1);
 
    Console.Write("Último número: ");
    Int32.TryParse(Console.ReadLine()!, out numero2);    
}
while(numero1 > numero2);
 
aux = numero1;
Console.WriteLine();
 
while(aux <= numero2)
{
    Console.Write($"{aux} ");
    aux++;
}
 
Console.WriteLine();
Console.WriteLine($"Esta foi a sequência de números de {numero1} a {numero2}");
Console.WriteLine();