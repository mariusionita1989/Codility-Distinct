using Codility_Distinct;

namespace Codility_DistinctTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 1, 2, 3, 1 }, 3)] // Example from the prompt
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, 1)]    // All elements are the same
        [InlineData(new int[] { }, 0)]                  // Empty array
        [InlineData(new int[] { -1, 0, 1, -1, 0, 1 }, 3)] // Negative and positive numbers
        [InlineData(new int[] { -1_000_000, 1_000_000, 0 }, 3)] // Edge case with extreme values
        public void TestSolution(int[] inputArray, int expectedDistinctCount)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int result = solution.solution(inputArray);

            // Assert
            Assert.Equal(expectedDistinctCount, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 3)]  // Array with distinct values
        [InlineData(new int[] { 1, 1, 2, 2, 3 }, 3)]  // Array with duplicate values
        [InlineData(new int[] { 1, 2, 3, 1, 2, 3 }, 3)]  // Array with all distinct values
        public void TestSolutionWithDifferentInputs(int[] inputArray, int expectedDistinctCount)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int result = solution.solution(inputArray);

            // Assert
            Assert.Equal(expectedDistinctCount, result);
        }

        [Fact]
        public void TestSolutionWithInvalidInput()
        {
            // Arrange
            Solution solution = new Solution();
            int[] invalidArray = new int[Solution.RANGE_HIGHEST_VALUE + 1];  // Array size exceeds the allowed range

            // Act
            int result = solution.solution(invalidArray);

            // Assert
            Assert.Equal(-1, result);
        }
    }
}