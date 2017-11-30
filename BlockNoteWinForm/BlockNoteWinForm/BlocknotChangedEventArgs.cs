using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockNoteWinForm
{
    class BlocknotChangedEventArgs:EventArgs
    {public  Record Record { get; set; }
        public BlocknotChangeType CheType { get; set; }
    }
}
