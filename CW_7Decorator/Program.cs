//Logan Walsh
//2/14/2023
//This program is a test program for a decorator

using System;

namespace CW_7Decorator
{
    public interface Widget
    {
        void draw();
    }
    public abstract class Decorator : Widget
    {
        Widget wid;

        public Decorator(Widget w)
        {
            wid = w;
        }
        public virtual void draw()
        {
            wid.draw();
        }
    }
    public class TextField : Widget
    {
        int width;
        int height;

        public TextField(int w, int h)
        {
            w = width;
            h = height;
        }
        public void draw() { }
    }
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w) { }
        public override void draw()
        {
            base.draw();
            Console.WriteLine("I am a scroll decorator, holding a red border");
        }
    }
    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w) { }
        public override void draw()
        {
            base.draw();
            Console.WriteLine("I am a scroll decorator, I will change the scrollbar's color");
        }
    }
    public class ButtonDecorator : Decorator
    {
        public ButtonDecorator(Widget w) : base(w) { }
        public override void draw()
        {
            base.draw();
            Console.WriteLine("I am a button decorator, I will change the color of the buttons");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            TextField message = new TextField(15, 20);
            BorderDecorator border = new BorderDecorator(message);
            ScrollDecorator scroll = new ScrollDecorator(border);
            ButtonDecorator button = new ButtonDecorator(scroll);
            button.draw();
            Console.ReadKey();
        }
    }
}
