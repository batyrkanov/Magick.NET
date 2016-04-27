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
using System.Text;

namespace ImageMagick
{
  [System.CodeDom.Compiler.GeneratedCode("Magick.NET.FileGenerator", "")]
  public sealed partial class Drawables
  {
    /// <summary>
    /// Creates a new DrawableAffine instance.
    /// </summary>
    /// <param name="scaleX">The X coordinate scaling element.</param>
    /// <param name="scaleY">The Y coordinate scaling element.</param>
    /// <param name="shearX">The X coordinate shearing element.</param>
    /// <param name="shearY">The Y coordinate shearing element.</param>
    /// <param name="translateX">The X coordinate of the translation element.</param>
    /// <param name="translateY">The Y coordinate of the translation element.</param>
    public Drawables Affine(double scaleX, double scaleY, double shearX, double shearY, double translateX, double translateY)
    {
      _Drawables.Add(new DrawableAffine(scaleX, scaleY, shearX, shearY, translateX, translateY));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableOpacity instance.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    /// <param name="paintMethod">The paint method to use.</param>
    public Drawables Alpha(double x, double y, PaintMethod paintMethod)
    {
      _Drawables.Add(new DrawableAlpha(x, y, paintMethod));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableArc instance.
    /// </summary>
    /// <param name="startX">The starting X coordinate of the bounding rectangle.</param>
    /// <param name="startY">The starting Y coordinate of thebounding rectangle.</param>
    /// <param name="endX">The ending X coordinate of the bounding rectangle.</param>
    /// <param name="endY">The ending Y coordinate of the bounding rectangle.</param>
    /// <param name="startDegrees">The starting degrees of rotation.</param>
    /// <param name="endDegrees">The ending degrees of rotation.</param>
    public Drawables Arc(double startX, double startY, double endX, double endY, double startDegrees, double endDegrees)
    {
      _Drawables.Add(new DrawableArc(startX, startY, endX, endY, startDegrees, endDegrees));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableBezier instance.
    /// </summary>
    /// <param name="coordinates">The coordinates.</param>
    public Drawables Bezier(params PointD[] coordinates)
    {
      _Drawables.Add(new DrawableBezier(coordinates));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableBezier instance.
    /// </summary>
    /// <param name="coordinates">The coordinates.</param>
    public Drawables Bezier(IEnumerable<PointD> coordinates)
    {
      _Drawables.Add(new DrawableBezier(coordinates));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableColor instance.
    /// </summary>
    /// <param name="color">The color of the border.</param>
    public Drawables BorderColor(MagickColor color)
    {
      _Drawables.Add(new DrawableBorderColor(color));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableCircle instance.
    /// </summary>
    /// <param name="originX">The origin X coordinate.</param>
    /// <param name="originY">The origin Y coordinate.</param>
    /// <param name="perimeterX">The perimeter X coordinate.</param>
    /// <param name="perimeterY">The perimeter Y coordinate.</param>
    public Drawables Circle(double originX, double originY, double perimeterX, double perimeterY)
    {
      _Drawables.Add(new DrawableCircle(originX, originY, perimeterX, perimeterY));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableClipPath instance.
    /// </summary>
    /// <param name="clipPath">The ID of the clip path.</param>
    public Drawables ClipPath(string clipPath)
    {
      _Drawables.Add(new DrawableClipPath(clipPath));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableClipRule instance.
    /// </summary>
    /// <param name="fillRule">The rule to use when filling drawn objects.</param>
    public Drawables ClipRule(FillRule fillRule)
    {
      _Drawables.Add(new DrawableClipRule(fillRule));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableClipUnits instance.
    /// </summary>
    /// <param name="units">The clip path units.</param>
    public Drawables ClipUnits(ClipPathUnit units)
    {
      _Drawables.Add(new DrawableClipUnits(units));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableColor instance.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    /// <param name="paintMethod">The paint method to use.</param>
    public Drawables Color(double x, double y, PaintMethod paintMethod)
    {
      _Drawables.Add(new DrawableColor(x, y, paintMethod));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableCompositeImage instance.
    /// </summary>
    /// <param name="offset">The offset from origin.</param>
    /// <param name="image">The image to draw.</param>
    public Drawables Composite(MagickGeometry offset, MagickImage image)
    {
      _Drawables.Add(new DrawableComposite(offset, image));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableCompositeImage instance.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    /// <param name="image">The image to draw.</param>
    public Drawables Composite(double x, double y, MagickImage image)
    {
      _Drawables.Add(new DrawableComposite(x, y, image));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableCompositeImage instance.
    /// </summary>
    /// <param name="offset">The offset from origin.</param>
    /// <param name="compose">The algorithm to use.</param>
    /// <param name="image">The image to draw.</param>
    public Drawables Composite(MagickGeometry offset, CompositeOperator compose, MagickImage image)
    {
      _Drawables.Add(new DrawableComposite(offset, compose, image));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableCompositeImage instance.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    /// <param name="compose">The algorithm to use.</param>
    /// <param name="image">The image to draw.</param>
    public Drawables Composite(double x, double y, CompositeOperator compose, MagickImage image)
    {
      _Drawables.Add(new DrawableComposite(x, y, compose, image));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableDensity instance.
    /// </summary>
    /// <param name="density">The vertical and horizontal resolution.</param>
    public Drawables Density(double density)
    {
      _Drawables.Add(new DrawableDensity(density));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableDensity instance.
    /// </summary>
    /// <param name="pointDensity">The vertical and horizontal resolution.</param>
    public Drawables Density(PointD pointDensity)
    {
      _Drawables.Add(new DrawableDensity(pointDensity));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableEllipse instance.
    /// </summary>
    /// <param name="originX">The origin X coordinate.</param>
    /// <param name="originY">The origin Y coordinate.</param>
    /// <param name="radiusX">The X radius.</param>
    /// <param name="radiusY">The Y radius.</param>
    /// <param name="startDegrees">The starting degrees of rotation.</param>
    /// <param name="endDegrees">The ending degrees of rotation.</param>
    public Drawables Ellipse(double originX, double originY, double radiusX, double radiusY, double startDegrees, double endDegrees)
    {
      _Drawables.Add(new DrawableEllipse(originX, originY, radiusX, radiusY, startDegrees, endDegrees));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableFillColor instance.
    /// </summary>
    /// <param name="color">The color to use.</param>
    public Drawables FillColor(MagickColor color)
    {
      _Drawables.Add(new DrawableFillColor(color));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableFillOpacity instance.
    /// </summary>
    /// <param name="opacity">The opacity.</param>
    public Drawables FillOpacity(Percentage opacity)
    {
      _Drawables.Add(new DrawableFillOpacity(opacity));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableFillPatternUrl instance.
    /// </summary>
    /// <param name="url">Url specifying pattern ID (e.g. "#pattern_id").</param>
    public Drawables FillPatternUrl(string url)
    {
      _Drawables.Add(new DrawableFillPatternUrl(url));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableFillRule instance.
    /// </summary>
    /// <param name="fillRule">The rule to use when filling drawn objects.</param>
    public Drawables FillRule(FillRule fillRule)
    {
      _Drawables.Add(new DrawableFillRule(fillRule));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableFont instance.
    /// </summary>
    /// <param name="family">The font family or the full path to the font file.</param>
    public Drawables Font(string family)
    {
      _Drawables.Add(new DrawableFont(family));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableFont instance.
    /// </summary>
    /// <param name="family">The font family or the full path to the font file.</param>
    /// <param name="style">The style of the font.</param>
    /// <param name="weight">The weight of the font.</param>
    /// <param name="stretch">The font stretching type.</param>
    public Drawables Font(string family, FontStyleType style, FontWeight weight, FontStretch stretch)
    {
      _Drawables.Add(new DrawableFont(family, style, weight, stretch));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePointSize instance.
    /// </summary>
    /// <param name="pointSize">The point size.</param>
    public Drawables FontPointSize(double pointSize)
    {
      _Drawables.Add(new DrawableFontPointSize(pointSize));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableGravity instance.
    /// </summary>
    /// <param name="gravity">The gravity.</param>
    public Drawables Gravity(Gravity gravity)
    {
      _Drawables.Add(new DrawableGravity(gravity));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableLine instance.
    /// </summary>
    /// <param name="startX">The starting X coordinate.</param>
    /// <param name="startY">The starting Y coordinate.</param>
    /// <param name="endX">The ending X coordinate.</param>
    /// <param name="endY">The ending Y coordinate.</param>
    public Drawables Line(double startX, double startY, double endX, double endY)
    {
      _Drawables.Add(new DrawableLine(startX, startY, endX, endY));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePath instance.
    /// </summary>
    /// <param name="paths">The paths to use.</param>
    public Drawables Path(params IPath[] paths)
    {
      _Drawables.Add(new DrawablePath(paths));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePath instance.
    /// </summary>
    /// <param name="paths">The paths to use.</param>
    public Drawables Path(IEnumerable<IPath> paths)
    {
      _Drawables.Add(new DrawablePath(paths));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePoint instance.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    public Drawables Point(double x, double y)
    {
      _Drawables.Add(new DrawablePoint(x, y));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePolygon instance.
    /// </summary>
    /// <param name="coordinates">The coordinates.</param>
    public Drawables Polygon(params PointD[] coordinates)
    {
      _Drawables.Add(new DrawablePolygon(coordinates));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePolygon instance.
    /// </summary>
    /// <param name="coordinates">The coordinates.</param>
    public Drawables Polygon(IEnumerable<PointD> coordinates)
    {
      _Drawables.Add(new DrawablePolygon(coordinates));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePolyline instance.
    /// </summary>
    /// <param name="coordinates">The coordinates.</param>
    public Drawables Polyline(params PointD[] coordinates)
    {
      _Drawables.Add(new DrawablePolyline(coordinates));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePolyline instance.
    /// </summary>
    /// <param name="coordinates">The coordinates.</param>
    public Drawables Polyline(IEnumerable<PointD> coordinates)
    {
      _Drawables.Add(new DrawablePolyline(coordinates));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePopClipPath instance.
    /// </summary>
    public Drawables PopClipPath()
    {
      _Drawables.Add(new DrawablePopClipPath());
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePopGraphicContext instance.
    /// </summary>
    public Drawables PopGraphicContext()
    {
      _Drawables.Add(new DrawablePopGraphicContext());
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePopPattern instance.
    /// </summary>
    public Drawables PopPattern()
    {
      _Drawables.Add(new DrawablePopPattern());
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePushClipPath instance.
    /// </summary>
    /// <param name="clipPath">The ID of the clip path.</param>
    public Drawables PushClipPath(string clipPath)
    {
      _Drawables.Add(new DrawablePushClipPath(clipPath));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePushGraphicContext instance.
    /// </summary>
    public Drawables PushGraphicContext()
    {
      _Drawables.Add(new DrawablePushGraphicContext());
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawablePushPattern instance.
    /// </summary>
    /// <param name="id">The ID of the pattern.</param>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    /// <param name="width">The width.</param>
    /// <param name="height">The height.</param>
    public Drawables PushPattern(string id, double x, double y, double width, double height)
    {
      _Drawables.Add(new DrawablePushPattern(id, x, y, width, height));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableRectangle instance.
    /// </summary>
    /// <param name="upperLeftX">The upper left X coordinate.</param>
    /// <param name="upperLeftY">The upper left Y coordinate.</param>
    /// <param name="lowerRightX">The lower right X coordinate.</param>
    /// <param name="lowerRightY">The lower right Y coordinate.</param>
    public Drawables Rectangle(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY)
    {
      _Drawables.Add(new DrawableRectangle(upperLeftX, upperLeftY, lowerRightX, lowerRightY));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableRotation instance.
    /// </summary>
    /// <param name="angle">The angle.</param>
    public Drawables Rotation(double angle)
    {
      _Drawables.Add(new DrawableRotation(angle));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableRoundRectangle instance.
    /// </summary>
    /// <param name="centerX">The center X coordinate.</param>
    /// <param name="centerY">The center Y coordinate.</param>
    /// <param name="width">The width.</param>
    /// <param name="height">The height.</param>
    /// <param name="cornerWidth">The corner width.</param>
    /// <param name="cornerHeight">The corner height.</param>
    public Drawables RoundRectangle(double centerX, double centerY, double width, double height, double cornerWidth, double cornerHeight)
    {
      _Drawables.Add(new DrawableRoundRectangle(centerX, centerY, width, height, cornerWidth, cornerHeight));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableScaling instance.
    /// </summary>
    /// <param name="x">Horizontal scale factor.</param>
    /// <param name="y">Vertical scale factor.</param>
    public Drawables Scaling(double x, double y)
    {
      _Drawables.Add(new DrawableScaling(x, y));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableSkewX instance.
    /// </summary>
    /// <param name="angle">The angle.</param>
    public Drawables SkewX(double angle)
    {
      _Drawables.Add(new DrawableSkewX(angle));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableSkewY instance.
    /// </summary>
    /// <param name="angle">The angle.</param>
    public Drawables SkewY(double angle)
    {
      _Drawables.Add(new DrawableSkewY(angle));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableStrokeAntialias instance.
    /// </summary>
    /// <param name="isEnabled">True if stroke antialiasing is enabled otherwise false.</param>
    public Drawables StrokeAntialias(bool isEnabled)
    {
      _Drawables.Add(new DrawableStrokeAntialias(isEnabled));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableStrokeColor instance.
    /// </summary>
    /// <param name="color">The color to use.</param>
    public Drawables StrokeColor(MagickColor color)
    {
      _Drawables.Add(new DrawableStrokeColor(color));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableDashArray instance.
    /// </summary>
    /// <param name="dash">An array containing the dash information.</param>
    public Drawables StrokeDashArray(params double[] dash)
    {
      _Drawables.Add(new DrawableStrokeDashArray(dash));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableStrokeDashOffset instance.
    /// </summary>
    /// <param name="offset">The dash offset.</param>
    public Drawables StrokeDashOffset(double offset)
    {
      _Drawables.Add(new DrawableStrokeDashOffset(offset));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableStrokeLineCap instance.
    /// </summary>
    /// <param name="lineCap">The line cap.</param>
    public Drawables StrokeLineCap(LineCap lineCap)
    {
      _Drawables.Add(new DrawableStrokeLineCap(lineCap));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableStrokeLineJoin instance.
    /// </summary>
    /// <param name="lineJoin">The line join.</param>
    public Drawables StrokeLineJoin(LineJoin lineJoin)
    {
      _Drawables.Add(new DrawableStrokeLineJoin(lineJoin));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableMiterLimit instance.
    /// </summary>
    /// <param name="miterlimit">The miter limit.</param>
    public Drawables StrokeMiterLimit(int miterlimit)
    {
      _Drawables.Add(new DrawableStrokeMiterLimit(miterlimit));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableStrokeOpacity instance.
    /// </summary>
    /// <param name="opacity">The opacity.</param>
    public Drawables StrokeOpacity(Percentage opacity)
    {
      _Drawables.Add(new DrawableStrokeOpacity(opacity));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableStrokePatternUrl instance.
    /// </summary>
    /// <param name="url">Url specifying pattern ID (e.g. "#pattern_id").</param>
    public Drawables StrokePatternUrl(string url)
    {
      _Drawables.Add(new DrawableStrokePatternUrl(url));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableStrokeWidth instance.
    /// </summary>
    /// <param name="width">The width.</param>
    public Drawables StrokeWidth(double width)
    {
      _Drawables.Add(new DrawableStrokeWidth(width));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableText instance.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    /// <param name="value">The text to draw.</param>
    public Drawables Text(double x, double y, string value)
    {
      _Drawables.Add(new DrawableText(x, y, value));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTextAntialias instance.
    /// </summary>
    /// <param name="alignment">Text alignment.</param>
    public Drawables TextAlignment(TextAlignment alignment)
    {
      _Drawables.Add(new DrawableTextAlignment(alignment));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTextAntialias instance.
    /// </summary>
    /// <param name="isEnabled">True if text antialiasing is enabled otherwise false.</param>
    public Drawables TextAntialias(bool isEnabled)
    {
      _Drawables.Add(new DrawableTextAntialias(isEnabled));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTextDecoration instance.
    /// </summary>
    /// <param name="decoration">The text decoration.</param>
    public Drawables TextDecoration(TextDecoration decoration)
    {
      _Drawables.Add(new DrawableTextDecoration(decoration));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTextDirection instance.
    /// </summary>
    /// <param name="direction">Direction to use.</param>
    public Drawables TextDirection(TextDirection direction)
    {
      _Drawables.Add(new DrawableTextDirection(direction));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTextEncoding instance.
    /// </summary>
    /// <param name="encoding">Encoding to use.</param>
    public Drawables TextEncoding(Encoding encoding)
    {
      _Drawables.Add(new DrawableTextEncoding(encoding));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTextInterlineSpacing instance.
    /// </summary>
    /// <param name="spacing">Spacing to use.</param>
    public Drawables TextInterlineSpacing(double spacing)
    {
      _Drawables.Add(new DrawableTextInterlineSpacing(spacing));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTextInterwordSpacing instance.
    /// </summary>
    /// <param name="spacing">Spacing to use.</param>
    public Drawables TextInterwordSpacing(double spacing)
    {
      _Drawables.Add(new DrawableTextInterwordSpacing(spacing));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTextKerning instance.
    /// </summary>
    /// <param name="kerning">Kerning to use.</param>
    public Drawables TextKerning(double kerning)
    {
      _Drawables.Add(new DrawableTextKerning(kerning));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTextUnderColor instance.
    /// </summary>
    /// <param name="color">The color to use.</param>
    public Drawables TextUnderColor(MagickColor color)
    {
      _Drawables.Add(new DrawableTextUnderColor(color));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableTranslation instance.
    /// </summary>
    /// <param name="x">The X coordinate.</param>
    /// <param name="y">The Y coordinate.</param>
    public Drawables Translation(double x, double y)
    {
      _Drawables.Add(new DrawableTranslation(x, y));
      return this;
    }
    
    /// <summary>
    /// Creates a new DrawableViewbox instance.
    /// </summary>
    /// <param name="upperLeftX">The upper left X coordinate.</param>
    /// <param name="upperLeftY">The upper left Y coordinate.</param>
    /// <param name="lowerRightX">The lower right X coordinate.</param>
    /// <param name="lowerRightY">The lower right Y coordinate.</param>
    public Drawables Viewbox(double upperLeftX, double upperLeftY, double lowerRightX, double lowerRightY)
    {
      _Drawables.Add(new DrawableViewbox(upperLeftX, upperLeftY, lowerRightX, lowerRightY));
      return this;
    }
    
  }
}
