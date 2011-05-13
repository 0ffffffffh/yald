using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace yald
{
    class DoubleBufferedListView : ListView
    {
        public DoubleBufferedListView()
        {
            //HACK!
            //force listview to using double buffer
            DoubleBuffered = true;
        }
    }
}
