﻿using System;

namespace CW_7Decorator
{
    class DecoratorDemo
    {
        interface Widget
        {
            public void draw();
        }
        public class TextField
        {
            int width;
            int height;

            TextField(int w, int h);
        }
        abstract class Decorator : Widget
        {
            Widget wid;

            public Decorator(Widget w);
            public void draw();
        }
        public class BorderDecorator : Decorator
        {
            public Decorator(Widget w)
            {

            }
            public void draw()
            {

            }
        }
        public class ScrollDecorator : Decorator
        {
            public Decorator(Widget w)
            {

            }
            public void draw()
            {

            }
        }
        static void Main(string[] args)
        {
        }
    }
}