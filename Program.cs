int numero;

Console.WriteLine("DIGITE UM NÚMERO PARA CÁLCUOLO DA TABUADA:");
numero = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"numero digitado :{numero}");
int contador = 1;

while (contador <= 10)
{
    int resultado = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {resultado}");
    Thread.Sleep(200);
    contador = contador + 1;
}

Console.WriteLine("FIM");