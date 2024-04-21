using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWFileFormats
{
    internal class Helper : Form1
    {
        public void enableLightEditBoxes()
        {
            lgtRadius.ReadOnly = false;
            lgtDropoff.ReadOnly = false;
            xCoordBox.ReadOnly = false;
            yCoordBox.ReadOnly = false;
            zCoordBox.ReadOnly = false;
        }
    }
}
