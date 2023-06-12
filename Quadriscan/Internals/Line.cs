using Microsoft.Xna.Framework;

namespace Quadriscan.Internals;

internal struct Line {
    public Point start;
    public Point end;

    public Line(Point start, Point end) {
        this.start = start;
        this.end = end;
    }

    public Line (int x1, int y1, int x2, int y2) {
        this.start = new(x1, y1);
        this.end = new(x2, y2);
    }

    public int x1 { get => start.X; }
    public int y1 { get => start.Y; }
    public int x2 { get => end.X; }
    public int y2 { get => end.Y; }

    public int dy { get => end.Y - start.Y; }
    public int dx { get => end.X - start.X; }
    public Vector2 displacement { get => new Vector2(dx, dy); }

    public void Deconstruct(out Point start, out Point end) {
        start = this.start;
        end = this.end;
    }

    public void Deconstruct(out int x1, out int y1, out int x2, out int y2) {
        this.start.Deconstruct(out x1, out y1);
        this.end.Deconstruct(out x2, out y2);
    }
}