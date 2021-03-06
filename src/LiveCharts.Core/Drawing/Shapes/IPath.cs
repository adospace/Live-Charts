﻿#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 Alberto Rodríguez Orozco & LiveCharts contributors
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
// of the Software, and to permit persons to whom the Software is furnished to 
// do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using LiveCharts.Drawing.Brushes;

namespace LiveCharts.Drawing.Shapes
{
    /// <summary>
    /// Defines a path in the user interface.
    /// </summary>
    public interface IPath : ICanvasElement, IDashable
    {
        /// <summary>
        /// Gets or sets the fill brush.
        /// </summary>
        Brush? Fill { get; set; }

        /// <summary>
        /// Gets or sets the stroke brush.
        /// </summary>
        Brush? Stroke { get; set; }

        /// <summary>
        /// Gets or sets the index of the z.
        /// </summary>
        /// <value>
        /// The index of the z.
        /// </value>
        int ZIndex { get; set; }

        /// <summary>
        /// Gets or sets the opacity.
        /// </summary>
        /// <value>
        /// The opacity.
        /// </value>
        double Opacity { get; set; }

        /// <summary>
        /// Gets or sets the start point.
        /// </summary>
        /// <value>
        /// The start point.
        /// </value>
        PointD StartPoint { get; set; }

        /// <summary>
        /// Adds a segment to the path.
        /// </summary>
        /// <param name="segment">The segment instance.</param>
        /// <param name="index">The index to insert the segment at.</param>
        void InsertSegment(IPathSegment segment, int index);

        /// <summary>
        /// Removes the segment from the path.
        /// </summary>
        /// <param name="segment">The segment.</param>
        void RemoveSegment(IPathSegment segment);
    }
}
