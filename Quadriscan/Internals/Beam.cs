using Microsoft.Xna.Framework;

namespace Quadriscan.Internals;

internal class Beam {
    /// <sumamry>
    /// The current position of the beam.
    /// </summary>
    public Point pos { get; private set; }
    /// <sumamry>
    /// The last position of the beam.
    /// </summary>
    public Point lastPos { get; private set; }

    private Color color;
    private byte intensity;
    private bool colorEnabled;
    
    private Color cachedColor;
    private bool cacheValid;

    public Beam() {
        pos = new();
        color = Color.White;
        intensity = 15;
        colorEnabled = false;
        cacheValid = false;
    }

    /// <summary>
    /// Get the current color, based on the intensity, color, and other 
    /// settings of the beam.
    /// </summary>
    public Color GetColor() {
        // This is probably a hilariously low priority, but I wanted an excuse to do caching. 
        if (!cacheValid) computeColor();
        return cachedColor;
    }

    private void computeColor() {
        byte r, g, b;
        color.Deconstruct(out r, out g, out b);
        if (!colorEnabled) r = g = b = 17;
        
        cacheValid = true;
        cachedColor = new Color(r * intensity, g * intensity, b * intensity);
    }

    /// <sumamry>
    /// Set the color code, in accordance with the COLOR instruction.
    /// en: Whether colors are enabled. If not, we just ignore the color
    ///             and default to white.
    /// colorCode:  The code used for a color, as specified by the Atari. 
    ///             0 is white, 1 is yellow, 2 is purple, 3 is red, 4 is cyan,
    ///             5 is green, 6 is blue. Most other values default to white.
    /// intensity:  How bright/intense the color is. 15 is full. Wraps around.
    /// </summary>
    public void setColor(bool en, byte colorCode, byte intensity) {
        this.colorEnabled = en;
        this.intensity = (byte) (intensity & 0xF);

        switch (colorCode) {
            case 0:
            default:
                color = new Color(17,17,17);
                break;
            case 1:
            case 8:
                color = new Color(17,17,0);
                break;
            case 2:
                color = new Color(17,0,17);
                break;
            case 3:
            case 12:
                color = new Color(17,0,0);
                break;
            case 4:
                color = new Color(0,17,17);
                break;
            case 5:
                color = new Color(0,17,0);
                break;
            case 6:
            case 7:
                color = new Color(0,0,17);
                break;
        }
    }

    public void Position(Point position) {
        pos = position;
        lastPos = position;
    }

    /// <summary>
    /// Move the beam by a relative amount.
    /// </summary>
    public void Move(Point displacement) {
        lastPos = pos;
        pos += displacement;
    }

    /// <summary>
    /// Show how the beam most recently moved. 
    /// Returns a line from the last position of the beam to the current position. 
    /// </summary>
    public Line LastPath() {
        return new(lastPos, pos);
    }
}