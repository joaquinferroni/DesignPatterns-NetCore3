using System.Collections.Generic;

public interface ISortStrategy
    {
        IList<string> DoSort(IList<string> data);
    }