using System;
using System.Diagnostics;

namespace PropertiesPt2 // Note: actual namespace depends on the project name.
{
    class Box
    {
        // Member variables
        private int _height; 
        private int _volume;

        public Box(int length, int width, int height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        
        public int Length { get; set; }

        public int Width { get; set; }

        public int Volume 
        { 
            get
            {
                return Height * Length * Width;
            }
            set
            {
                if(value < 0 )
                    this._height = -value;
                else 
                    this._height = value;
            } 
        }

        public int Height
        {
            get
            {
                return this._height;
            }
            set 
            {
                if(value < 0 )
                    this._height = -value;
                else 
                    this._height = value;
            }
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", 
                                    this.Length, this.Height, this.Width, this.Volume = this.Length * this.Height * this.Width);
        }

    }
}