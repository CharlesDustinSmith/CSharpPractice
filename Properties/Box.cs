using System;
using System.Diagnostics;

namespace Properties // Note: actual namespace depends on the project name.
{
    class Box
    {
        // Member variables
        private int _length;
        private int _height; 
        private int _width;
        private int _volume;
        
        // Set Methods
        public void SetLength(int length)
        {
            if(length <= 0)
            {
                int lineNumber = new StackTrace(true).GetFrame(0).GetFileLineNumber();
                throw new Exception("The length should be greater than 0 \nLine : " + (lineNumber+1));
            }
            this._length = length;
        }

        public void SetHeight(int height)
        {
            this._height = height; 
        }

        public void SetWidth(int width)
        {
            this._width = width;
        }

        // Get Methods
        public int GetLength()
        {
            return this._length;
        }

        public int GetHeight()
        {
            return this._height;
        }

        public int GetWidth()
        {
            return this._width;
        }

        public int GetVolume()
        {
            return this._width * this ._height * this._length;                                                                               
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", 
                                    this._length, this._height, this._width, this._volume = this._length * this._height * this._width);
        }

    }
}