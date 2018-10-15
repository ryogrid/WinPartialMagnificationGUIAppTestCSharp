using System.Windows.Forms;

class Program
{
    static void Main()
    {
        Form fm = new Form();
        Karna.Magnification.Magnifier mag = new Karna.Magnification.Magnifier(fm);
        Application.Run(fm);
    }
}
