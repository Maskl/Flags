﻿namespace Flags
{
    public class SearchParamsMessage
    {
        public SearchParamsMessage(string v)
        {
            SearchParams = v;
        }

        public string SearchParams { get; private set; }
    }
}
