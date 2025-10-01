using LinkedList.Easy;

namespace LinkedListUnitTests.Easy
{
    public class RemoveDuplicatesUnitTests
    {
        [Theory]
        [MemberData(nameof(GetRemoveDuplicatesData))]
        public void TestRemoveDuplicates(LinkedList.LinkedList input, LinkedList.LinkedList expectedResult)
        {
            var result = RemoveDuplicates.RemoveDuplicatesFromLinkedList(input);
            Assert.Equivalent(expectedResult, result);
        }

        public static IEnumerable<object[]> GetRemoveDuplicatesData
        {
            get
            {
                var data = new List<object[]>
                {
                    new object[]
                    {
                        new LinkedList.LinkedList(1,
                            new LinkedList.LinkedList(1,
                                new LinkedList.LinkedList(1,
                                    new LinkedList.LinkedList(3,
                                        new LinkedList.LinkedList(4,
                                            new LinkedList.LinkedList(4,
                                                new LinkedList.LinkedList(4,
                                                    new LinkedList.LinkedList(4,
                                                        new LinkedList.LinkedList(5,
                                                            new LinkedList.LinkedList(6,
                                                                new LinkedList.LinkedList(6, null!))))))))))),
                        new LinkedList.LinkedList(1,
                            new LinkedList.LinkedList(3,
                                new LinkedList.LinkedList(4,
                                    new LinkedList.LinkedList(5,
                                        new LinkedList.LinkedList(6, null!))))),
                    },
                    new object[]
                    {
                        new LinkedList.LinkedList(1,
                            new LinkedList.LinkedList(1,
                                new LinkedList.LinkedList(1,
                                    new LinkedList.LinkedList(1,
                                        new LinkedList.LinkedList(1,
                                            new LinkedList.LinkedList(1,
                                                new LinkedList.LinkedList(1, null!))))))),
                        new LinkedList.LinkedList(1, null!),
                    },
                    new object[]
                    {
                        new LinkedList.LinkedList(1, null!),
                        new LinkedList.LinkedList(1, null!),
                    }
                };
                return data;
            }
        }
    }
}