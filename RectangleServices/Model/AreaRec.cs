using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RectangleServices.Model
{
    public class AreaRec
    {
        public int Length { get; set; }
        public int Width { get; set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public AreaRec()
        {
            
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public AreaRec(int length, int width)
        {
            Length = length;
            Width = width;
        }
    }
}
