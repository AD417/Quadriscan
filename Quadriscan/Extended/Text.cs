using System;
using Quadriscan.Internals;

namespace Quadriscan.Extended;

public static class Text {
    public static void Draw(string s, int x, int y) {
        int currentX = x, currentY = y;
        VectorGenerator.Position(x, y);
        foreach (char c in s) {
            if (c == '\n') {
                currentX = x;
                currentY += 32;
                continue;
            }
            Draw(c, currentX, currentY);
            currentX += 24;
        }
    }

    public static void Draw(char c, int x, int y) {
        VectorGenerator.Position(x, y);
        Draw(c);
    }

    public static void Draw(char c) {
        // HOOOOOO BOY!
        // TODO: Convert this to a JSON format.
        switch (Char.ToUpper(c)) {
        case 'A':
            VectorGenerator.Draw(0, 24, 0);
            VectorGenerator.Draw(0, -16, 15);
            VectorGenerator.Draw(8, -8, 15);
            VectorGenerator.Draw(8, 8, 15);
            VectorGenerator.Draw(0, 16, 15);
            VectorGenerator.Draw(0, -8, 0);
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
            VectorGenerator.Draw(12, 0, 15);
            break;
        case 'F':
            VectorGenerator.Draw(16, 0, 0);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(0, -12, 0);
            VectorGenerator.Draw(12, 0, 15);
            break;
        case 'G':
            VectorGenerator.Draw(16, 8, 0);
            VectorGenerator.Draw(0, -8, 15);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, -8, 15);
            VectorGenerator.Draw(-8, 0, 15);
            break;
        case 'H':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 0);
            VectorGenerator.Draw(0, -24, 15);
            VectorGenerator.Draw(-16, 12, 0);
            VectorGenerator.Draw(16, 0, 15);
            break;
        case 'I':
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, 24, 0);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(8, 0, 0);
            VectorGenerator.Draw(0, -24, 15);
            break;
        case 'J':
            VectorGenerator.Draw(0, 16, 0);
            VectorGenerator.Draw(8, 8, 15);
            VectorGenerator.Draw(8, 0, 15);
            VectorGenerator.Draw(0, -24, 15);
            break;
        case 'K':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 0);
            VectorGenerator.Draw(-16, -12, 15);
            VectorGenerator.Draw(16, -12, 15);
            break;
        case 'L':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            break;
        case 'M':
            VectorGenerator.Draw(0, 24, 0);
            VectorGenerator.Draw(0, -24, 15);
            VectorGenerator.Draw(8, 8, 15);
            VectorGenerator.Draw(8, -8, 15);
            VectorGenerator.Draw(0, 24, 15);
            break;
        case 'N':
            VectorGenerator.Draw(0, 24, 0);
            VectorGenerator.Draw(0, -24, 15);
            VectorGenerator.Draw(16, 24, 15);
            VectorGenerator.Draw(0, -24, 15);
            break;
        case 'O':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, -24, 15);
            VectorGenerator.Draw(-16, 0, 15);
            break;
        case 'P':
            VectorGenerator.Draw(0, 24, 0);
            VectorGenerator.Draw(0, -24, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(-16, 0, 15);
            break;
        case 'Q':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(8, 0, 15);
            VectorGenerator.Draw(8, -8, 15);
            VectorGenerator.Draw(0, -16, 15);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(8, 16, 0);
            VectorGenerator.Draw(8, 8, 15);
            break;
        case 'R':
            VectorGenerator.Draw(0, 24, 0);
            VectorGenerator.Draw(0, -24, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(4, 0, 0);
            VectorGenerator.Draw(12, 12, 15);
            break;
        case 'S':
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(-16, 0, 15);
            break;
        case 'T':
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(-8, 0, 0);
            VectorGenerator.Draw(0, 24, 15);
            break;
        case 'U':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, -24, 15);
            break;
        case 'V':
            VectorGenerator.Draw(8, 24, 15);
            VectorGenerator.Draw(8, -24, 15);
            break;
        case 'W':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(8, -8, 15);
            VectorGenerator.Draw(8, 8, 15);
            VectorGenerator.Draw(0, -24, 15);
            break;
        case 'X':
            VectorGenerator.Draw(16, 24, 15);
            VectorGenerator.Draw(-16, 0, 0);
            VectorGenerator.Draw(16, -24, 15);
            break;
        case 'Y':
            VectorGenerator.Draw(8, 8, 15);
            VectorGenerator.Draw(8, -8, 15);
            VectorGenerator.Draw(-8, 8, 0);
            VectorGenerator.Draw(0, 16, 15);
            break;
        case 'Z':
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(-16, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            break;
        case ' ':
            // Ha ha.
            break;
        case '1':
            VectorGenerator.Draw(8, 0, 0);
            VectorGenerator.Draw(0, 24, 15);
            break;
        case '2':
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(16, 0, 15);
            break;
        case '3':
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, -12, 0);
            VectorGenerator.Draw(16, 0, 15);
            break;
        case '4':
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(0, -24, 15);
            break;
        case '5':
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(-16, 0, 15);
            break;
        case '6':
            VectorGenerator.Draw(16, 0, 0);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, -12, 15);
            VectorGenerator.Draw(-16, 0, 15);
            break;
        case '7':
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, 24, 15);
            break;
        case '8':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, -24, 15);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 12, 0);
            VectorGenerator.Draw(16, 0, 15);
            break;
        case '9':
            VectorGenerator.Draw(0, 24, 0);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, -24, 15);
            VectorGenerator.Draw(-16, 0, 15);
            VectorGenerator.Draw(0, 12, 15);
            VectorGenerator.Draw(16, 0, 15);
            break;
        case '0':
            VectorGenerator.Draw(0, 24, 15);
            VectorGenerator.Draw(16, 0, 15);
            VectorGenerator.Draw(0, -24, 15);
            VectorGenerator.Draw(-16, 0, 15);
            break;
        default:
            throw new NotImplementedException("Cannot render character " + c);
        }
    }
}