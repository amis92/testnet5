class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
        X();
    }

    static void X() => new MyListNode();
}

class Node { }

struct NodeList<T> where T : Node
{
    public static implicit operator NodeList<Node>(NodeList<T> nodeList) => new NodeList<Node>();
}

abstract class ListNode<T> where T : Node
{
    public abstract ListNode<T> WithNodes(NodeList<T> nodes);
}

class MyNode : Node { }

class MyListNode : ListNode<MyNode>
{
    public override MyListNode WithNodes(NodeList<MyNode> nodes) => new MyListNode();
}
