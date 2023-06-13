using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Quadriscan.Instructions;

namespace Quadriscan.Internals;

internal static class VectorGenerator {
    private static CRT monitor;
    private static Beam beam;
    private static List<Action<Beam>> instructions;

    public static void initialize(GraphicsDevice g, uint width, uint height) {
        monitor = new(g, width, height);
        beam = new();
        instructions = new();
    }

    public static void Position(Point p) {
        beam.Position(p);
    }

    public static void Position(int dx, int dy) => Position(new(dx, dy));

    public static void Draw(Point p, byte brightness = 15) {
        beam.Brightness = brightness;
        beam.Move(p);
        monitor.DrawLine(beam.LastPath(), beam.GetColor());
    }

    public static void Draw(int dx, int dy, byte brightness = 15) => Draw(new(dx, dy), brightness);

    public static void Color(bool enabled, byte colorId, byte brightness) {
        beam.setColor(enabled, colorId, brightness);
    }

    public static void Scale(byte digital, byte analog) {
        beam.setScale(digital, analog);
    }

    public static void Display() {
        monitor.Display();
    }

    public static void Testcat() {
        monitor.Blank();
        Scale(1, 0);
        for (int i = 20; i < 400; i += 30) {
            Position(i, 80);
            // A
            Draw(0, -16, 15);
            Draw(8, -8, 15);
            Draw(8, 8, 15);
            Draw(0, 16, 15);
            Draw(0, -8, 15);
            Draw(-16, 0, 15);
        }
        monitor.Display();
    }
}