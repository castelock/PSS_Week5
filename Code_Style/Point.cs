using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Style
{
    /// <summary>Class Point models a point in a two-dimensional
    /// plane.</summary>
    class Point
    {
        private int X { get; set; }
        private int Y { get; set; }

        #region Methods
        /// <summary>This method changes the point's location to
        ///    the given coordinates.</summary>
        /// <param name="xor">the new x-coordinate.</param>
        /// <param name="yor">the new y-coordinate.</param>
        public void Move(int xor, int yor)
        {
            X = xor;
            Y = yor;
        }

        /// <summary>This method changes the point's location to
        ///    the given coordinates.</summary>
        /// <param name="xor">the new x-coordinate.</param>
        /// <param name="yor">the new y-coordinate.</param>
        /// <exception cref="NullReferenceException">Throws the exception when 
        /// the x-coordinate is null.</exception>
        public void translateX(int x)
        {
            if (x == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                this.X += x;
            }
            
        }

        /// <summary>Report a point's location as a string.</summary>
        /// <returns>A string representing a point's location, in the form (x,y),
        ///    without any leading, trailing, or embedded whitespace.</returns>
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
        #endregion
    }
}
