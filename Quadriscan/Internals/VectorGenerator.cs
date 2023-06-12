using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Quadriscan.Internals;

internal static class VectorGenerator {
    private static CRT monitor;
    private static Beam beam;

    public static void initialize(GraphicsDevice g, uint width, uint height) {
        monitor = new(g, width, height);
        beam = new();
    }

    public static void Position(Point p) {
        beam.Position(p);
    }

    public static void Position(int dx, int dy) => Position(new(dx, dy));

    public static void Draw(Point p) {
        beam.Move(p);
        monitor.DrawLine(beam.LastPath(), beam.GetColor());
    }

    public static void Draw(int dx, int dy) => Draw(new(dx, dy));

    public static void Display() {
        monitor.Display();
    }

    public static void Testcat() {
        monitor.Blank();
        beam.setColor(true, 3, 15);
        Position(200, 200);
        Draw(50, 50);
        Draw(-50, 50);
        Draw(-50, -50);
        Draw(50, -50);
        monitor.Display();
    }
}