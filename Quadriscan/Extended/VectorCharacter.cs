using Quadriscan.Internals;

namespace Quadriscan.Extended;

abstract class VectorCharacter {
    internal void Draw(int x, int y) {
        VectorGenerator.Position(x, y);
        Draw();
    }
    abstract internal void Draw();
}