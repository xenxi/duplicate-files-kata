using System.Collections.Generic;
using System.Linq;

namespace DuplicateFilesKata {
    public class DuplicateCleanner {
        public List<string> Clean(List<string> aGivenListOfString) {
            return aGivenListOfString.Distinct().ToList();
        }
    }
}