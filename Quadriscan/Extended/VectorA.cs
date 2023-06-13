using Quadriscan.Internals;

namespace Quadriscan.Extended;

class VectorA : VectorCharacter {
    internal override void Draw() {
        VectorGenerator.Draw(0, 24, 0);
        VectorGenerator.Draw(0, -16, 15);
        VectorGenerator.Draw(8, -8, 15);
        VectorGenerator.Draw(8, 8, 15);
        VectorGenerator.Draw(0, 16, 15);
        VectorGenerator.Draw(0, -8, 15);
        VectorGenerator.Draw(-16, 0, 15);
    }
}