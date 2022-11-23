using Codes;

// FilaCircular fila = new FilaCircular(10);

// if (fila.IsEmpty())
// {
//     System.Console.WriteLine("Fila Vazia!");
// }
// else
// {
//     fila.ShowQueue();
// }
// for (int i = 2; i <= 12; i++)
// {
//     if (!fila.InQueue(i))
//     {
//         System.Console.WriteLine("Neste momento a fila se encontra cheia, \nnão entrará novos itens até que os primeiros itens saiam.\n");
//         break;
//     }
// }
// fila.ShowQueue();

// System.Console.WriteLine(fila.DeQueue());

// System.Console.WriteLine(fila.SearchQueue("Teste"));
// System.Console.WriteLine(fila.InQueue(500));
// fila.ShowQueue();
// System.Console.WriteLine(fila.DeQueue()); System.Console.WriteLine(fila.DeQueue());
// fila.ShowQueue();
// fila.InQueue('A');
// fila.InQueue(DateTime.Now);

// System.Console.WriteLine("\nMostrando a fila final:\n");
// fila.ShowQueue();

CalculadoraPolonesa calc = new(10);

System.Console.WriteLine("Escreva uma função no estilo polones:");
System.Console.WriteLine(calc.Insere(Console.ReadLine()));

