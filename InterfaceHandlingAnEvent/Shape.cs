using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHandlingAnEvent
{
    public class Shape : ISquare, IRectangle
    {
        public event EventHandler DrawEvent1;
        public event EventHandler DrawEvent2;

        object objectLock = new Object();

        event EventHandler ISquare.Draw
        {
            add
            {
                lock (objectLock)
                {
                    DrawEvent1 += value;
                }
            }
            remove
            {
                lock (objectLock)
                {
                    DrawEvent1 -= value;
                }
            }
        }

        event EventHandler IRectangle.Draw
        {
            add
            {
                DrawEvent2 += value;
            }
            remove
            {
                DrawEvent2 -= value;
            }
        }

        public void Draw()
        {
            EventHandler handler = DrawEvent1;

            handler?.Invoke(this, new EventArgs());
            Console.WriteLine("Drawing a shape.");

            handler = DrawEvent2;
            handler?.Invoke(this, new EventArgs());
        }
    }
}
