using System.Windows.Ink;

namespace ScreenToGif.ModelEx.Sequences
{
    public class DrawingSequence : Sequence
    {
        public StrokeCollection Strokes { get; set; }


        public DrawingSequence()
        {
            Type = Types.Drawing;
        }
    }
}