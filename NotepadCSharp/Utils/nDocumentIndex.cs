﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadCSharp.Utils
{
    public class nDocumentIndex
    {
        public static List<int> GetIndexes(string pText, string pSearchText, bool pCaseSensitive)
        {
            var Indexes = new List<int>();
            var eStringComparison = pCaseSensitive ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
            var StartIndex = 0;
            while (true)
            {
                var Index = pText.IndexOf(pSearchText, StartIndex, eStringComparison);
                if (Index == -1) break;
                Indexes.Add(Index);
                StartIndex = Index + pSearchText.Length;
            }
            return Indexes;
        }
    }
}
