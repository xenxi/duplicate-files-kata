using System.Collections.Generic;
using Xunit;

namespace DuplicateFilesKata.Tests
{
    public class DuplicateCleannerShould
    {
        private readonly DuplicateCleanner _duplicateCleanner;

        public DuplicateCleannerShould() {
            _duplicateCleanner = new DuplicateCleanner();
        }

        [Fact]
        public void return_a_list_of_strings() {
            var aGivenListOfString = new List<string> { "anyString", "anyDiferentString"};

            var  cleaned = _duplicateCleanner.Clean(aGivenListOfString);

            Assert.Equal(aGivenListOfString, cleaned);
        }
    }
}