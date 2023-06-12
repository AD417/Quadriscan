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
        for (int i = 20; i < 400; i += 30) {
            Position(i, 40);
            // A
            Draw(0, -20);
            Draw(10, -10);
            Draw(10, 10);
            Draw(0, 20);
            Draw(0, -10);
            Draw(-20, 0);
        }
        monitor.Display();
    }
}