
using System.Reflection.Metadata.Ecma335;
var tree1 = new TreeNode(4);

TreeNode tree2 = new TreeNode(4);
tree2.Children.Add(new TreeNode(2));
tree2.Children.Add(new TreeNode(1));


TreeNode tree3 = new TreeNode(4);
tree3.Children.Add(new TreeNode(1));
tree3.Children.Add(new TreeNode(2));
tree3.Children.Add(new TreeNode(5));
tree3.Children[1].Children.Add(new TreeNode(3));
tree3.Children[2].Children.Add(new TreeNode(1));
tree3.Children[2].Children.Add(new TreeNode(4));


var intervw = new Interview();
Console.WriteLine("------------------------------------Respuesta 17 ------------------------------------------------------------------\n");
Console.WriteLine(intervw.respuesta17(5,3)); //cambiar aqui los argumentos para las pruebas necesarias

Console.WriteLine("------------------------------------Respuesta 18 ------------------------------------------------------------------\n");
Console.WriteLine(intervw.respuesta18(287,4)); //cambiar aqui los argumentos para las pruebas necesarias

Console.WriteLine("------------------------------------Respuesta 19 ------------------------------------------------------------------\n");
Console.WriteLine("Propiedades del árbol 1:");
Console.WriteLine("Peso: " + TreeProperties.CalculateWeight(tree1));
Console.WriteLine("Peso promedio: " + TreeProperties.CalculateAverageWeight(tree1));
Console.WriteLine("Altura: " + TreeProperties.CalculateHeight(tree1));

Console.WriteLine("Propiedades del árbol 2:");
Console.WriteLine("Peso: " + TreeProperties.CalculateWeight(tree2));
Console.WriteLine("Peso promedio: " + TreeProperties.CalculateAverageWeight(tree2));
Console.WriteLine("Altura: " + TreeProperties.CalculateHeight(tree2));

Console.WriteLine("Propiedades del árbol 3:");
Console.WriteLine("Peso: " + TreeProperties.CalculateWeight(tree3));
Console.WriteLine("Peso promedio: " + TreeProperties.CalculateAverageWeight(tree3));
Console.WriteLine("Altura: " + TreeProperties.CalculateHeight(tree3));
public class Interview
{
    //respuesta17
    public string respuesta17(decimal number1, decimal number2)
    {
        if (number2 != 0)
        {
            return "Respuesta 17: El resultado de la division es: " + number1 / number2;
        }
        else
        {
            return "Respuesta 17: No se puede dividir entre cero";
        }
    }

    //repuesta 18
    public string respuesta18(int x, int k)
    {
        string initialNumber = x.ToString();
        string baseNumberK="";

        while (x > 0) {
            int residuo = x % k;
            baseNumberK = residuo.ToString() + baseNumberK;
            x /= k;
        }
        
        return initialNumber + " en base 10 = "+ baseNumberK + " En base "+k;
    }

}

// respuesta 19
public class TreeNode
{
    public int Value { get; }
    public List<TreeNode> Children { get; }

    public TreeNode(int value)
    {
        Value = value;
        Children = new List<TreeNode>();
    }
}

public class TreeProperties

{

    public static int CalculateWeight(TreeNode root)
    {
        if (root == null)
            return 0;
        int weight = root.Value;
        foreach (var child in root.Children)
        {
            weight += CalculateWeight(child);
        }
        return weight;

    }

    public static double CalculateAverageWeight(TreeNode root)

    {

        int weight = CalculateWeight(root);

        int nodesCount = CountNodes(root);

        if (nodesCount == 0)

            return 0;

        return (double)weight / nodesCount;

    }

    public static int CalculateHeight(TreeNode root)

    {

        if (root == null)

            return 0;

        int maxHeight = 0;

        foreach (var child in root.Children)

        {

            maxHeight = Math.Max(maxHeight, CalculateHeight(child));

        }

        return maxHeight + 1;

    }

    private static int CountNodes(TreeNode root)

    {

        if (root == null)

            return 0;

        int count = 1;

        foreach (var child in root.Children)

        {

            count += CountNodes(child);

        }

        return count;

    }

}







    





