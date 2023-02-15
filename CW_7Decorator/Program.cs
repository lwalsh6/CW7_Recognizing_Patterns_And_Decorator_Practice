//Logan Walsh
//2/14/2023
//This program is a test program for a decorator

using System;

namespace CW_7Decorator
{
    class DecoratorDemo
    {
        public interface Widget
        {
            public void draw();
        }
        public class TextField
        {
            int width;
            int height;

            TextField(int w, int h)
            {

            }
        }
        abstract class Decorator 
        {
            Widget wid;

             public void draw()
            {

            }
        }
        public class BorderDecorator //Add : Decorator?
        {
            public BorderDecorator(Widget w)
            {

            }
            public void draw()
            {
                Console.WriteLine("I Am adding a Border");
            }
        }
        public class ScrollDecorator //Add : Decorator?
        {
            public ScrollDecorator(Widget w) 
            {

            }
            public void draw()
            {
                Console.WriteLine("I Am adding a Scrollbar");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
