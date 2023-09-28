using System;

namespace ClassBoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                lenght = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get 
            {
                return height; 
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value; 
            }
        }

        public double SurfaceArea()
        {
            return 2 * this.Lenght * this.Width +
                2 * this.Lenght * this.Height +
                2 * this.Width * this.Height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.Lenght * this.Height +
                2 * this.Width * this.Height;
        }

        public double Volume()
        {
            return this.Lenght * this.Width * this.Height;
        }
    }
}
