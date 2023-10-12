using System;

namespace ClassProperties
{
    public class Box
    {
        // regular member variables
        private int length = 3;
        private int height;

        // shorthand for implementing getter and setter for a member
        public int Width { get; set; }

        // the long way of implementing getter and setter directly on member 
        // the way that C# actually compiles getters and setters on the members
        /*
            public int Width
            {
                get
                {
                    return this.width;
                }
                set
                {
                    this.width = value;
                }
            }
        */

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = 0;
                }
                else
                {
                    height = value;
                }
            }
        }

        // explicit getter
        public int GetLength()
        {
            return this.length;
        }

        // explicit setter
        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("length");
            }
            this.length = length;
        }


        // the long way of implementing getter directly on member
        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }

    }
}

