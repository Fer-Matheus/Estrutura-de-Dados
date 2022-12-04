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

//Questão 02 - Calculadora Polonesa

// CalculadoraPolonesa calc = new(10);

// System.Console.WriteLine("Escreva uma função no estilo polones:");
// calc.Insere(Console.ReadLine());

// System.Console.WriteLine(calc.RetornaCalc());

// Questão 03 - Embaralhamento

// int[] s1 = { 1, 2, 3, 4, 5 };
// int[] s2 = { 6, 7, 8, 9, 10 };

// Pilha p1 = new(5);
// Pilha p2 = new(5);
// Pilha p3 = new(5);
// PushAll(s1, ref p1);
// PushAll(s2, ref p2);

// System.Console.WriteLine("Pilhas antes de embaralhar:");
// System.Console.WriteLine("Pilha 1:");
// p1.Show();
// System.Console.WriteLine("Pilha 2:");
// p2.Show();
// System.Console.WriteLine();

// for (int i = 0; i < 5; i++)
// {
//     p3.Push(p1.Pop());
// }
// for (int i = 0; i < 5; i++)
// {
//     p1.Push(p2.Pop());
// }

// System.Console.WriteLine("Pilhas depois de embaralhar:");
// p1.Show();
// System.Console.WriteLine();
// p3.Show();
// System.Console.WriteLine();


// static void PushAll(int[] s1, ref Pilha p1)
// {
//     foreach (var item in s1)
//     {
//         p1.Push(item);
//     }
// }
// Criptograma
// string mensagem = "Matheus está doente, e portanto não poderá frequentar as aulas dessa semana.";
// System.Console.WriteLine("Mensagem antes de codificar:\n\n" + mensagem);
// Criptograma cripto = new(mensagem.Split(" ").Length);
// System.Console.WriteLine("\nMensagem depois de codificar:\n\n" + cripto.Codifica(mensagem.Split(" ")));
// string codificada = cripto.Codifica(mensagem.Split(" "));

// System.Console.WriteLine($"\nTamanho da mensagem: {mensagem.Split(" ").Length}, tamanho da mensagem codificada: {codificada.Split(" ").Length}");

// string decodificada = cripto.Decodificar(codificada.Split(" "));

// System.Console.WriteLine("Mensagem decodificada:\n\n" + decodificada);

// Empilhadeira

// Caixa[] caixas = { new Caixa(6), new Caixa(10), new Caixa(14), new Caixa(6), new Caixa(10), new Caixa(14) };
// Caixa[] caixas = { new(6), new(6), new(10), new(10), new(14), new(14) }; // entre paremteses temos os pesos

// Empilhadeira empi = new Empilhadeira(caixas.Length);

// empi.RecebeCaixas(caixas);
// empi.MostrarPilhas();
// empi.Organizar();
// empi.MostrarPilhas();


// Lista lista = new();
// Random random = new();

// for (int i = 0; i < 100000; i++)
// {
//     lista.adiciona();
// }
// TimeSpan[] tempos = new TimeSpan[100];
// DateTime inicio, fim;
// int a = 1, b = 1000;

// for (int i = 0; i < 100; i++, a += 1000, b += 1000)
// {
//     inicio = DateTime.Now;
//     for (int j = 0; j < 100; j++)
//     {
//         lista.Busca(random.Next(a, b));
//     }
//     fim = DateTime.Now;
//     tempos[i] = fim - inicio;
// }
// TimeSpan acu = TimeSpan.FromSeconds(0);
// foreach (var item in tempos)
// {
//     System.Console.WriteLine(item.Milliseconds);
//     acu += item;
// }
// File.WriteAllLines("C:\\workspace\\CSharpProjects\\Estrutura-de-dados\\Questao 11\\dados.cvs", tempos.Select(item => item.Milliseconds.ToString()));
// System.Console.WriteLine($"Tempo médio: {acu / 100}");

// Usuario[] usuarios = { new(0, 4), new(1, 12), new(2, 20), new(3, 1), new(4, 4), new(5, 1), new(6, 1), };
// FilaCircular fila = new(10);
// foreach (var item in usuarios)
// {
//     fila.InQueue(new Ticket(item));
// }
// TimeSpan acu = TimeSpan.Zero;
// System.Console.WriteLine(acu);
// for (int i = 0; i < usuarios.Length; i++)
// {
//     Ticket x = (Ticket)fila.DeQueue();
//     acu += x.Realizar();
//     System.Console.WriteLine(acu);
// }

// System.Console.WriteLine($"Média de espera da fila: {(acu / usuarios.Length)}");


// // ListaEncadeadaSimplesCircular lista = new ListaEncadeadaSimplesCircular();
// // ListaEncadeadaSimples lista = new ListaEncadeadaSimples();
// ListaDuplamenteEncadeadaCircular lista = new();

// for (int i = 1; i <= 10; i++)
// {
//     lista.Insert(new(i));
// }
// lista.ShowList();

// // System.Console.WriteLine(lista.Search(2));

// // lista.Remove(10);

// // System.Console.WriteLine("Insert não ordenado:\n");

// // lista.Insert(new(100));

// // lista.ShowList();
// System.Console.WriteLine("Inserindo mais um elemento:\n");
// lista.Insert(new(500));
// lista.ShowList();

// lista.InsertNaoOrdenado(new(1000), 6);

// lista.ShowList();

// lista.Remove(6);
// lista.Insert(new(200));

// lista.ShowList();

// lista.InsertNaoOrdenado(new(1001), 6);

// lista.ShowList();



// System.Console.WriteLine($"Esse é o First: {lista.First} e esse é o Last: {lista.Last}");
// System.Console.WriteLine($"Esse é o anterior do First: {lista.First.Anterior} e esse é o proximo do First: {lista.First.Proximo}");
// System.Console.WriteLine($"Esse é o anterior do Last: {lista.Last.Anterior} e esse é o proximo do Last: {lista.Last.Proximo}");
// System.Console.WriteLine("Destruindo...\n");

// // // lista.DestructListCirc();
// lista.DestructList();
// lista.ShowList();

// lista.InsertNaoOrdenado(new(500), 1);
// lista.ShowList();

// CalculadoraPolonesaAvançada calc = new(10);

// System.Console.WriteLine("Escreva uma função no estilo polones:\n OBS: Lembre de por espaços entre os operandos!\n");
// calc.Insere(Console.ReadLine());

// System.Console.WriteLine(calc.RetornaCalc());

ListaBlocos lista = new();

for (int i = 0; i < 5; i++)
{
    lista.InsertBlock(new(i, 5));
}
lista.ShowListBlock();
lista.ShowListBlockNo();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        lista.InsertNo(i, new(j));
    }
}

lista.ShowListBlockNo();

System.Console.WriteLine(lista.SearchBlock(3));

System.Console.WriteLine(lista.SearchBlockNo(3, 3));