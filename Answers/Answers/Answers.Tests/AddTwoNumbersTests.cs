using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Answers.Tests
{
    [TestClass]
    public class AddTwoNumbersTests
    {
        [TestMethod]
        public void AddTwoListWithNullValue()
        {
            // Given
            AddTwoNumbersSolution.ListNode listNode1 = new AddTwoNumbersSolution.ListNode(2);
            AddTwoNumbersSolution.ListNode nextNode1 = new AddTwoNumbersSolution.ListNode(4);
            listNode1.next = nextNode1;
            AddTwoNumbersSolution.ListNode nextNode2 = new AddTwoNumbersSolution.ListNode(3);
            nextNode1.next = nextNode2;

            AddTwoNumbersSolution.ListNode listNode2 = new AddTwoNumbersSolution.ListNode(5);
            AddTwoNumbersSolution.ListNode nextNode21 = new AddTwoNumbersSolution.ListNode(6);
            listNode2.next = nextNode21;
            AddTwoNumbersSolution.ListNode nextNode22 = new AddTwoNumbersSolution.ListNode(4);
            nextNode21.next = nextNode22;

            // When
            AddTwoNumbersSolution add = new AddTwoNumbersSolution();
            var result = add.AddTwoNumbers(listNode1, listNode2);

            // Then
            Assert.AreEqual(7, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(8, result.next.next.val);
        }
    }
}
