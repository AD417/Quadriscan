using System;
using Quadriscan.Internals;

namespace Quadriscan.Extended;

public static class Text {
    public static void Draw(char c, int x, int y) {
        VectorGenerator.Position(x, y);
        Draw(c);
    }

    public static void Draw(char c) {
        // HOOOOOO BOY!
        switch (Char.ToUpper(c)) {
        case 'A':
            VectorGenerator.Draw(0, 24, 0);
            VectorGenerator.Draw(0, -16, 15);
            VectorGenerator.Draw(8, -8, 15);
            VectorGenerator.Draw(8, 8, 15);
            VectorGenerator.Draw(0, 16, 15);
            VectorGenerator.Draw(0, -8, 15);
            VectorGenerator.Draw(-16, 0, 15);
            break;
        case 'B':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(12, 0, 15);
            VectorGenerator.Draw(4, -4, 15);
            VectorGenerator.Draw(0, -4, 15);
            VectorGenerator.Draw(-4, -4, 15);
            VectorGenerator.Draw(4, -4, 15);
            VectorGenerator.Draw(0, -4, 15);
            VectorGenerator.Draw(-4, -4, 15);
            VectorGenerator.Draw(-12, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(12, 0, 15);
            break;
        case 'C':
            VectorGenerator.Draw(16, 0, 0);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            break;
        case 'D':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(8, 0, 15);
            VectorGenerator.Draw(8, -8, 15);
            VectorGenerator.Draw(0, -8, 15);
            VectorGenerator.Draw(-8, -8, 15);
            VectorGenerator.Draw(-8, 0, 15);
            break;
        case 'E':
            VectorGenerator.Draw(16, 0, 0);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(-16, -12, 0);
            VectorGenerator.Draw(12, 0);
            break;
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        default:
            throw new NotImplementedException("Cannot render character " + c);
        }
    }
}