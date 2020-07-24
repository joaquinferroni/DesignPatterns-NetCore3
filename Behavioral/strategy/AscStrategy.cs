using System.Collections.Generic;
using System.Linq;
public class AscStrategy : ISortStrategy
    {
        public IList<string> DoSort(IList<string> data)
        {
            return data.OrderBy(x => x).ToList();
        }
    }