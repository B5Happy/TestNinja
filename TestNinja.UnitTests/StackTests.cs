using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_AddNullObj_TrowException()
        {
            var stack = new TestNinja.Fundamentals.Stack<string>();


            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_AddObj_ListContainObj()
        {
            var stack = new Fundamentals.Stack<int>();

            stack.Push(1);

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Fundamentals.Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_RemoveObjFromAnExmptyList_TrowException()
        {
            var stack = new TestNinja.Fundamentals.Stack<string>();


            Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_stackWithAFewObjects_ReturnObjectOnTheTop()
        {
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.Pop();

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Pop_stackWithAFewObjects_RemoveObjectOnTheTop()
        {
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_RemoveObjectOnTheTop()
        {
            var stack = new Fundamentals.Stack<int>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTheTopOfTheStack()
        {
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo(3));

        }

        [Test]
        public void Peek_StackWithObjects_DoesNotReturnObjectOnTheTopOfTheStack()
        {
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));

        }


    }
}
