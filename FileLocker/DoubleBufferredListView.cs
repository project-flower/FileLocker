using System.Windows.Forms;

public class DoubleBufferedListView : ListView
{
    protected override bool DoubleBuffered
    {
        get { return true; }
        set { }
    }
}
