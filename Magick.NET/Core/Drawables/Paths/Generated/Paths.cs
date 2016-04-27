//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System.Collections.Generic;

namespace ImageMagick
{
  [System.CodeDom.Compiler.GeneratedCode("Magick.NET.FileGenerator", "")]
  public sealed partial class Paths
  {
    /// <summary>
    /// Initializes a new instance of the PathArcAbs class.
    /// </summary>
    /// <param name="pathArcs">The coordinates to use.</param>
    public Paths ArcAbs(params PathArc[] pathArcs)
    {
      _Paths.Add(new PathArcAbs(pathArcs));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathArcAbs class.
    /// </summary>
    /// <param name="pathArcs">The coordinates to use.</param>
    public Paths ArcAbs(IEnumerable<PathArc> pathArcs)
    {
      _Paths.Add(new PathArcAbs(pathArcs));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathArcRel class.
    /// </summary>
    /// <param name="pathArcs">The coordinates to use.</param>
    public Paths ArcRel(params PathArc[] pathArcs)
    {
      _Paths.Add(new PathArcRel(pathArcs));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathArcRel class.
    /// </summary>
    /// <param name="pathArcs">The coordinates to use.</param>
    public Paths ArcRel(IEnumerable<PathArc> pathArcs)
    {
      _Paths.Add(new PathArcRel(pathArcs));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathClose class.
    /// </summary>
    public Paths Close()
    {
      _Paths.Add(new PathClose());
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathCurveToAbs class.
    /// </summary>
    /// <param name="controlPointStart">Coordinate of control point for curve beginning</param>
    /// <param name="controlPointEnd">Coordinate of control point for curve ending</param>
    /// <param name="end">Coordinate of the end of the curve</param>
    public Paths CurveToAbs(PointD controlPointStart, PointD controlPointEnd, PointD end)
    {
      _Paths.Add(new PathCurveToAbs(controlPointStart, controlPointEnd, end));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathCurveToAbs class.
    /// </summary>
    /// <param name="x1">X coordinate of control point for curve beginning</param>
    /// <param name="y1">Y coordinate of control point for curve beginning</param>
    /// <param name="x2">X coordinate of control point for curve ending</param>
    /// <param name="y2">Y coordinate of control point for curve ending</param>
    /// <param name="x">X coordinate of the end of the curve</param>
    /// <param name="y">Y coordinate of the end of the curve</param>
    public Paths CurveToAbs(double x1, double y1, double x2, double y2, double x, double y)
    {
      _Paths.Add(new PathCurveToAbs(x1, y1, x2, y2, x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathCurveToRel class.
    /// </summary>
    /// <param name="controlPointStart">Coordinate of control point for curve beginning</param>
    /// <param name="controlPointEnd">Coordinate of control point for curve ending</param>
    /// <param name="end">Coordinate of the end of the curve</param>
    public Paths CurveToRel(PointD controlPointStart, PointD controlPointEnd, PointD end)
    {
      _Paths.Add(new PathCurveToRel(controlPointStart, controlPointEnd, end));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathCurveToRel class.
    /// </summary>
    /// <param name="x1">X coordinate of control point for curve beginning</param>
    /// <param name="y1">Y coordinate of control point for curve beginning</param>
    /// <param name="x2">X coordinate of control point for curve ending</param>
    /// <param name="y2">Y coordinate of control point for curve ending</param>
    /// <param name="x">X coordinate of the end of the curve</param>
    /// <param name="y">Y coordinate of the end of the curve</param>
    public Paths CurveToRel(double x1, double y1, double x2, double y2, double x, double y)
    {
      _Paths.Add(new PathCurveToRel(x1, y1, x2, y2, x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLineToAbs class.
    /// </summary>
    /// <param name="coordinates">The coordinates to use.</param>
    public Paths LineToAbs(params PointD[] coordinates)
    {
      _Paths.Add(new PathLineToAbs(coordinates));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLineToAbs class.
    /// </summary>
    /// <param name="coordinates">The coordinates to use.</param>
    public Paths LineToAbs(IEnumerable<PointD> coordinates)
    {
      _Paths.Add(new PathLineToAbs(coordinates));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLineToAbs class.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    public Paths LineToAbs(double x, double y)
    {
      _Paths.Add(new PathLineToAbs(x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLineToHorizontalAbs class.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    public Paths LineToHorizontalAbs(double x)
    {
      _Paths.Add(new PathLineToHorizontalAbs(x));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLineToHorizontalRel class.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    public Paths LineToHorizontalRel(double x)
    {
      _Paths.Add(new PathLineToHorizontalRel(x));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLineToRel class.
    /// </summary>
    /// <param name="coordinates">The coordinates to use.</param>
    public Paths LineToRel(params PointD[] coordinates)
    {
      _Paths.Add(new PathLineToRel(coordinates));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLineToRel class.
    /// </summary>
    /// <param name="coordinates">The coordinates to use.</param>
    public Paths LineToRel(IEnumerable<PointD> coordinates)
    {
      _Paths.Add(new PathLineToRel(coordinates));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLineToRel class.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    public Paths LineToRel(double x, double y)
    {
      _Paths.Add(new PathLineToRel(x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLinetoVerticalAbs class.
    /// </summary>
    /// <param name="y">The Y coordinate.</param>
    public Paths LineToVerticalAbs(double y)
    {
      _Paths.Add(new PathLineToVerticalAbs(y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathLineToVerticalRel class.
    /// </summary>
    /// <param name="y">The Y coordinate.</param>
    public Paths LineToVerticalRel(double y)
    {
      _Paths.Add(new PathLineToVerticalRel(y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathMoveToAbs class.
    /// </summary>
    /// <param name="coordinate">The coordinate to use.</param>
    public Paths MoveToAbs(PointD coordinate)
    {
      _Paths.Add(new PathMoveToAbs(coordinate));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathMoveToAbs class.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    public Paths MoveToAbs(double x, double y)
    {
      _Paths.Add(new PathMoveToAbs(x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathMoveToRel class.
    /// </summary>
    /// <param name="coordinate">The coordinate to use.</param>
    public Paths MoveToRel(PointD coordinate)
    {
      _Paths.Add(new PathMoveToRel(coordinate));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathMoveToRel class.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    public Paths MoveToRel(double x, double y)
    {
      _Paths.Add(new PathMoveToRel(x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathQuadraticCurveToAbs class.
    /// </summary>
    /// <param name="controlPoint">Coordinate of control point</param>
    /// <param name="end">Coordinate of final point</param>
    public Paths QuadraticCurveToAbs(PointD controlPoint, PointD end)
    {
      _Paths.Add(new PathQuadraticCurveToAbs(controlPoint, end));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathQuadraticCurveToAbs class.
    /// </summary>
    /// <param name="x1">X coordinate of control point</param>
    /// <param name="y1">Y coordinate of control point</param>
    /// <param name="x">X coordinate of final point</param>
    /// <param name="y">Y coordinate of final point</param>
    public Paths QuadraticCurveToAbs(double x1, double y1, double x, double y)
    {
      _Paths.Add(new PathQuadraticCurveToAbs(x1, y1, x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathQuadraticCurveToRel class.
    /// </summary>
    /// <param name="controlPoint">Coordinate of control point</param>
    /// <param name="end">Coordinate of final point</param>
    public Paths QuadraticCurveToRel(PointD controlPoint, PointD end)
    {
      _Paths.Add(new PathQuadraticCurveToRel(controlPoint, end));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathQuadraticCurveToRel class.
    /// </summary>
    /// <param name="x1">X coordinate of control point</param>
    /// <param name="y1">Y coordinate of control point</param>
    /// <param name="x">X coordinate of final point</param>
    /// <param name="y">Y coordinate of final point</param>
    public Paths QuadraticCurveToRel(double x1, double y1, double x, double y)
    {
      _Paths.Add(new PathQuadraticCurveToRel(x1, y1, x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathSmoothCurveToAbs class.
    /// </summary>
    /// <param name="controlPoint">Coordinate of second point</param>
    /// <param name="end">Coordinate of final point</param>
    public Paths SmoothCurveToAbs(PointD controlPoint, PointD end)
    {
      _Paths.Add(new PathSmoothCurveToAbs(controlPoint, end));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathSmoothCurveToAbs class.
    /// </summary>
    /// <param name="x2">X coordinate of second point</param>
    /// <param name="y2">Y coordinate of second point</param>
    /// <param name="x">X coordinate of final point</param>
    /// <param name="y">Y coordinate of final point</param>
    public Paths SmoothCurveToAbs(double x2, double y2, double x, double y)
    {
      _Paths.Add(new PathSmoothCurveToAbs(x2, y2, x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathSmoothCurveToRel class.
    /// </summary>
    /// <param name="controlPoint">Coordinate of second point</param>
    /// <param name="end">Coordinate of final point</param>
    public Paths SmoothCurveToRel(PointD controlPoint, PointD end)
    {
      _Paths.Add(new PathSmoothCurveToRel(controlPoint, end));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathSmoothCurveToRel class.
    /// </summary>
    /// <param name="x2">X coordinate of second point</param>
    /// <param name="y2">Y coordinate of second point</param>
    /// <param name="x">X coordinate of final point</param>
    /// <param name="y">Y coordinate of final point</param>
    public Paths SmoothCurveToRel(double x2, double y2, double x, double y)
    {
      _Paths.Add(new PathSmoothCurveToRel(x2, y2, x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathSmoothQuadraticCurveToAbs class.
    /// </summary>
    /// <param name="end">Coordinate of final point</param>
    public Paths SmoothQuadraticCurveToAbs(PointD end)
    {
      _Paths.Add(new PathSmoothQuadraticCurveToAbs(end));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathSmoothQuadraticCurveToAbs class.
    /// </summary>
    /// <param name="x">X coordinate of final point</param>
    /// <param name="y">Y coordinate of final point</param>
    public Paths SmoothQuadraticCurveToAbs(double x, double y)
    {
      _Paths.Add(new PathSmoothQuadraticCurveToAbs(x, y));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathSmoothQuadraticCurveToRel class.
    /// </summary>
    /// <param name="end">Coordinate of final point</param>
    public Paths SmoothQuadraticCurveToRel(PointD end)
    {
      _Paths.Add(new PathSmoothQuadraticCurveToRel(end));
      return this;
    }

    /// <summary>
    /// Initializes a new instance of the PathSmoothQuadraticCurveToRel class.
    /// </summary>
    /// <param name="x">X coordinate of final point</param>
    /// <param name="y">Y coordinate of final point</param>
    public Paths SmoothQuadraticCurveToRel(double x, double y)
    {
      _Paths.Add(new PathSmoothQuadraticCurveToRel(x, y));
      return this;
    }

  }
}
