using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknoteWithInitIList
{
   static class Extension
    {
        public static IEnumerable<Record> ReturnRecordsByCondition(this IEnumerable<Record> Blocknote,
            Func<Record, bool> condition)
        {
            foreach (Record rec in Blocknote)
            {
                if (condition(rec))
                    yield return rec;
            }
        }

        public static IEnumerable<Record> FindRecord(this IEnumerable<Record> Blocknote,
            Func<Record, string, bool> condition, string str)
        {
            foreach (Record rec in Blocknote)
            {
                if (condition(rec, str))
                    yield return rec;
            }
        }

        public static void ShowBlock(this IEnumerable<Record> Blocknote, Action<Record> actionRec)
        {
            foreach (Record rec in Blocknote)
            {
                actionRec(rec);
            }
        }
    }
}
