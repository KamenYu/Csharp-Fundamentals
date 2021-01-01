using System;
using System.Collections.Generic;
using System.Linq;

namespace HowTOCopyADictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> thisDictionary = new Dictionary<string, int>();

            Dictionary<string, int> copiedAndFiltered = thisDictionary
                .OrderByDescending(x => x.Value)    // ordering by whatever
                .ThenBy(k => k.Key)
                .ToDictionary(a => a.Key, a => a.Value);
        }
    }
}
