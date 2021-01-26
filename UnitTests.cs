using System.Collections.Generic;
using NUnit.Framework;

namespace Testing
{
    public class UnitTests
    {

        [Test]
        public void Test1()
        {
            int[] input = new int[] {15, 32, 8, 99, 12};
            int min = MathUtil.FindMin(input);
            Assert.AreEqual(8, min);
        }

        [Test]
        public void Test2()
        {
            int[] input = new int[] {};
            int min = MathUtil.FindMin(input);
            Assert.AreEqual(0, min);
        }

        [Test]
        public void Test3()
        {
            int[] input = new int[] {2, 67, 10};
            int min = MathUtil.FindMin(input);
            Assert.AreEqual(2, min);
        }

        [Test]
        public void Test4()
        {
            List<Contact> contacts = AddressBook.FindContactsInCity("London");
            Assert.AreEqual(1, contacts.Count);
            Contact contact = contacts[0];
            Assert.AreEqual("John", contact.FirstName);
        }

    }
}