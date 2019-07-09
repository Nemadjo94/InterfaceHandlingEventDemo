using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHandlingAnEvent
{
    class ClassB
    {
        public ClassB(Shape shape)    
        {
            IRectangle rectangle = (IRectangle)shape;
            rectangle.Draw += new EventHandler(rectangle_Draw);
        }

        void rectangle_Draw(object Sender, EventArgs e)
        {
            Console.WriteLine("ClassB receives the rectangle event.");
        }
    }
}
