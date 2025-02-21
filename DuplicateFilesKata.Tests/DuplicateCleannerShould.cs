﻿using System.Collections.Generic;
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
        [Fact]
        public void remove_duplicates() {
            var aGivenListOfStringWithDuplicated = new List<string> { "anyString", "anyDiferentString", "anyString", "anyDiferentString"};

            var  cleaned = _duplicateCleanner.Clean(aGivenListOfStringWithDuplicated);

            var expectedListOfString = new List<string> { "anyString", "anyDiferentString"};
            Assert.Equal(expectedListOfString, cleaned);
        }
    }
}