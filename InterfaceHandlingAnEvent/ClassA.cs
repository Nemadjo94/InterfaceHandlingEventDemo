using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHandlingAnEvent
{
    class ClassA
    {
        //References the shape object as an square
        public ClassA(Shape shape)
        {
            ISquare square = (ISquare)shape;
            square.Draw += new EventHandler(square_Draw);
        }

        void square_Draw(object sender, EventArgs e)
        {
            Console.WriteLine("Class A receives the square event.");
        }
    }
}
