using Codigos.Estruturas;

Tree tree = new Tree();

int[] values = { 25, 23, 24, 22, 27, 26, 28 };
Object[] conts = { "Teste", 1001, true, false, "Matheus", 15.4, "Opa" };

for (int i = 0; i < 7; i++)
{
    tree.Insert(values[i], conts[i]);
}
tree.Show("C");
tree.Show("D");
tree.Show("L");

System.Console.WriteLine(tree.Search(26));
System.Console.WriteLine(tree.Search(100));

tree.Delete(25);

tree.Show("C");
tree.Show("D");
tree.Show("L");