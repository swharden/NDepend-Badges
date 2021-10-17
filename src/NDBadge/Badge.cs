using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;

namespace NDBadge
{
    public class Badge
    {
        readonly string Name;
        readonly string Value;
        readonly SizeF NameSize;
        readonly SizeF ValueSize;
        public Color BackgroundLeft = Color.FromArgb("#666");
        public Color BackgroundRight = Color.FromArgb("#08C");
        public Color BackgroundLiner = Colors.White.WithAlpha(.15f);
        public Color FontColor = Colors.White;
        public Color FontShadow = Colors.Black.WithAlpha(.5f);
        public Color OverlayTop = Colors.Black.WithAlpha(0);
        public Color OverlayBottom = Colors.Black.WithAlpha(.25f);

        public Badge(string name, string value)
        {
            Name = name;
            Value = value;
            NameSize = MeasureString(name);
            ValueSize = MeasureString(value);
        }

        public void SaveSVG(string svgFilePath)
        {
            float leftTextWidth = NameSize.Width;
            float rightTextWidth = ValueSize.Width;
            float imgWidth = leftTextWidth + rightTextWidth + 22;
            float leftBackgroundWidth = leftTextWidth + 10;
            float rightBackgroundWidth = imgWidth - leftBackgroundWidth;
            float imgHeight = 20;
            string colorLeft = "#555";
            string colorRight = "#007ec6";
            string colorText = "#FFF";

            string svg = $@"
<svg xmlns='http://www.w3.org/2000/svg'
    xmlns:xlink='http://www.w3.org/1999/xlink' width='{imgWidth}' height='{imgHeight}' role='img' aria-label='languages: 5'>
    <title>{Name}: {Value}</title>
    <linearGradient id='s' x2='0' y2='100%'>
        <stop offset='0' stop-color='#bbb' stop-opacity='.1'/>
        <stop offset='1' stop-opacity='.1'/>
    </linearGradient>
    <clipPath id='r'>
        <rect width='{imgWidth}' height='{imgHeight}' rx='3' fill='#fff'/>
    </clipPath>
    <g clip-path='url(#r)'>
        <rect width='{leftBackgroundWidth}' height='{imgHeight}' fill='{colorLeft}'/>
        <rect x='{leftBackgroundWidth}' width='{rightBackgroundWidth}' height='{imgHeight}' fill='{colorRight}'/>
        <rect width='{imgWidth}' height='{imgHeight}' fill='url(#s)'/>
    </g>
    <g fill='{colorText}' text-anchor='center' font-family='Verdana,Geneva,DejaVu Sans,sans-serif' text-rendering='geometricPrecision' font-size='110'>
        <text aria-hidden='true' x='{40}' y='150' fill='#010101' fill-opacity='.3' transform='scale(.1)' textLength='{leftTextWidth * 10}'>{Name}</text>
        <text x='{40}' y='140' transform='scale(.1)' fill='{colorText}' textLength='{leftTextWidth * 10}'>{Name}</text>
        <text aria-hidden='true' x='{40 + leftBackgroundWidth * 10}' y='150' fill='#010101' fill-opacity='.3' transform='scale(.1)' textLength='{rightTextWidth * 10}'>{Value}</text>
        <text x='{40 + leftBackgroundWidth * 10}' y='140' transform='scale(.1)' fill='{colorText}' textLength='{rightTextWidth * 10}'>{Value}</text>
    </g>
</svg>".Trim();
            System.IO.File.WriteAllText(svgFilePath, svg);
        }

        public void SavePng(string pngFilePath, float scale = 1)
        {
            float totalWidth = NameSize.Width + ValueSize.Width;
            int imageWidth = (int)totalWidth + 22;
            RectangleF imageRect = new(0, 0, imageWidth, 20);

            int scaledWidth = (int)(imageRect.Width * scale);
            int scaledHeight = (int)(imageRect.Height * scale);
            BitmapExportContext bmp = SkiaGraphicsService.Instance.CreateBitmapExportContext(scaledWidth, scaledHeight);
            ICanvas canvas = bmp.Canvas;
            canvas.Scale(scale, scale);

            // left background
            canvas.FillColor = BackgroundLeft;
            canvas.FillRoundedRectangle(imageRect, 5);

            // right background
            float bg2x = 10 + NameSize.Width;
            canvas.SaveState();
            canvas.ClipRectangle(bg2x, 0, bmp.Width, bmp.Height);
            canvas.FillColor = BackgroundRight;
            canvas.FillRoundedRectangle(imageRect, 5);
            canvas.RestoreState();

            // vertical line
            canvas.StrokeColor = BackgroundLiner;
            canvas.DrawLine(bg2x, 0, bg2x, bmp.Height);

            // background overlay shadow
            var pt = new LinearGradientPaint() { StartColor = OverlayTop, EndColor = OverlayBottom };
            canvas.SetFillPaint(pt, new Point(0, 0), new Point(0, bmp.Height));
            canvas.FillRoundedRectangle(imageRect, 5);


            // draw text backgrounds
            canvas.FontSize = 12;
            float offsetY = 14;
            float offsetX1 = 5;
            float offsetX2 = 15;
            float shadowOffset = 1;

            // text shadow
            canvas.FontColor = FontShadow;
            canvas.DrawString(Name, offsetX1 + shadowOffset, offsetY + shadowOffset, HorizontalAlignment.Left);
            canvas.DrawString(Value, offsetX2 + NameSize.Width + shadowOffset, offsetY + shadowOffset, HorizontalAlignment.Left);

            // text foreground
            canvas.FontColor = FontColor;
            canvas.DrawString(Name, offsetX1, offsetY, HorizontalAlignment.Left);
            canvas.DrawString(Value, offsetX2 + NameSize.Width, offsetY, HorizontalAlignment.Left);

            // save the output
            bmp.WriteToFile(pngFilePath);
        }

        public static SizeF MeasureString(string text, string fontName = "Arial", float fontSize = 12)
        {
            var fontService = new SkiaFontService("", "");
            using SkiaSharp.SKTypeface typeFace = fontService.GetTypeface(fontName);
            using SkiaSharp.SKPaint paint = new() { Typeface = typeFace, TextSize = fontSize };
            float width = paint.MeasureText(text);
            float height = fontSize;
            return new SizeF(width, height);
        }
    }
}
