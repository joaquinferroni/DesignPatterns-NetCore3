using System.Collections.Generic;
using System.Linq;

public class DescStrategy : ISortStrategy
    {
        public IList<string> DoSort(IList<string> data)
        {
            return data.OrderByDescending(x => x).ToList();
        }
    }