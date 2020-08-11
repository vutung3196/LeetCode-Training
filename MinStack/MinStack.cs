// https://leetcode.com/problems/min-stack/
using System;
using System.Collections;

public class MinStack
{
    private StackNode Head { get; set; }

    public void Push(int x)
    {
        if (Head == null)
        {
            Head = new StackNode(x, x, null);
        }
        else
        {
            Head = new StackNode(x, Math.Min(x, Head.Min), Head);
        }
    }

    public void Pop()
    {
        Head = Head.NextNode;
    }

    public int Top()
    {
        return Head.Val;
    }

    public int GetMin()
    {
        return Head.Min;
    }

}

public class StackNode
{
    public int Val { get; set; }
    public int Min { get; set; }
    public StackNode NextNode { get; set; }

    public StackNode(int val, int min, StackNode node)
    {
        Val = val;
        Min = min;
        NextNode = node;
    }
}
