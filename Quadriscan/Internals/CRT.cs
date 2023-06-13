using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Quadriscan.Internals;

internal class CRT {
    public uint width { get; private set; }
    public uint height { get; private set; }
    
    public Color[] buffer { get; private set; }
    
    private SpriteBatch sprite;
    internal Texture2D texture { get; private set; }
    
    internal CRT(GraphicsDevice g, uint width, uint height) {
        texture = new Texture2D(g, (int)width, (int)height);
        this.buffer = new Color[width * height];
        this.width = width;
        this.height = height;
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                buffer[x + y * width] = Color.Black;
            }
        }
        texture.SetData(buffer); // initialize texture buffer
        sprite = new SpriteBatch(g);
    }

    public void Blank() {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                setPixel(x, y, Color.Black);
            }
        }
    }

    private void setPixel(int x, int y, Color color) {
        if (width <= x || x < 0) return;
        if (height <= y || y < 0) return;
        buffer[x + y * width] = color;
    }

    private void setPixel(float x, float y, Color color) => setPixel((int)x, (int)y, color);

    internal void DrawLine(Line line, Color color) {
        if (line.x1 < 0 && line.x2 < 0) return;
        if (line.y1 < 0 && line.y2 < 0) return;
        if (line.x1 >= width && line.x2 >= width) return;
        if (line.y1 >= height && line.y2 >= height) return;

        float x = line.x1;
        float y = line.y1;
        int d = Math.Max(Math.Abs(line.dy), Math.Abs(line.dx));
        float dy = (float)line.dy / d;
        float dx = (float)line.dx / d;

        setPixel(x, y, color);
        for (int i = 0; i < d; i++) {
            x += dx;
            y += dy;
            setPixel(x, y, color);
        }
        /*
        Pointless Optimization:
        // Using fixed-point arithmetic. 
        // int x,y = XXXXXXXXXXXXXXXX.DDDDDDDDDDDDDDDD
        // the "decimal" is truncated. 
        // XXX: breaks when using lines bigger than 32k in either direction.
        int x = line.x1 << 16;
        int y = line.y1 << 16;

        int d = Math.Max(Math.Abs(line.dy), Math.Abs(line.dx));
        int dx = (line.dx << 16) / d;
        int dy = (line.dy << 16) / d;
        System.Console.WriteLine(dy);
        System.Console.WriteLine(dx);
        System.Console.WriteLine();

        for (int i = 0; i < d; i++) {
            x += dx;
            y += dy;
            if (x < 0 || y < 0) break;
            setPixel(x >> 16, y >> 16, color);
        }
        */
    }

    internal void Display() {
        texture.SetData(buffer);
        sprite.Begin();
        sprite.Draw(texture, Vector2.Zero, Color.White);
        sprite.End();
    }
}