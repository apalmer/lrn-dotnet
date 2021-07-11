using System;
using Xunit;
using lib;

namespace tests
{
    public class SimplePriorityQueueTests
    {
        [Fact]
        public void IsEmptyReturnsTrueWhenEmptyTest()
        {
            var queue = new SimplePriorityQueue();

            var actual = queue.IsEmpty();

            Assert.True(actual);
        }
        
        [Fact]
        public void IsEmptyReturnsFalseWhenNotEmptyTest()
        {
            var queue = new SimplePriorityQueue();
            queue.InsertWithPriority(3, 3);
            queue.InsertWithPriority(2, 2);
            queue.InsertWithPriority(1, 1);

            var actual = queue.IsEmpty();

            Assert.False(actual);
        }
    }
}
