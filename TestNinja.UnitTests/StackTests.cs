using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;

public class StackTests
{
    [Test]
    public void Push_ArgumentIsNull_ThrowArgumentNullException()
    {
        var stack = new Fundamentals.Stack<string>();
        Assert.That(
            () => stack.Push(null),
            Throws.ArgumentNullException
        );
    }

    [Test]
    public void Push_ValidArgument_AddObjectToTheStack()
    {
        var stack = new Fundamentals.Stack<string>();
        stack.Push("some tring");
        Assert.That(stack.Count, Is.EqualTo(1));
    }

    [Test]
    public void Pop_StackWithFewObjects_RemoveObjectOnTheTop()
    {
        var stack = new Fundamentals.Stack<string>();

        stack.Push("first string");
        stack.Push("second string");

        stack.Pop();

        Assert.That(stack.Count, Is.EqualTo(1));
    }

    [Test]
    public void Pop_StackWithFewObjects_ReturnObjectOnTheTop()
    {
        var stack = new Fundamentals.Stack<string>();

        stack.Push("a");
        stack.Push("b");
        stack.Push("c");

        var result = stack.Pop();

        Assert.That(result, Is.EqualTo("c"));
    }

    [Test]
    public void Pop_EmptyStack_ThrowInvalidOperationException()
    {
        var stack = new Fundamentals.Stack<int>();

        Assert.That(
            () => stack.Pop(),
            Throws.InvalidOperationException
        );
    }

    [Test]
    public void Peek_EmptyStack_ThrowInvalidOperationException()
    {
        var stack = new Fundamentals.Stack<int>();

        Assert.That(
            () => stack.Peek(),
            Throws.InvalidOperationException
        );
    }

    [Test]
    public void Peek_StackWithFewObjects_ReturnObjectOnTop()
    {
        var stack = new Fundamentals.Stack<int>();

        stack.Push(2);
        stack.Push(3);
        stack.Push(10);

        Assert.That(
            stack.Peek(),
            Is.EqualTo(10)
        );
    }
}
