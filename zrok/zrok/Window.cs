using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    public class Window
    {
        bool Open;

        public Window()
        {
        }

        public void OpenWindow()
        {
            Open = true;
        }

        public void CloseWindow()
        {
            Open = false;
        }

    }
}
