                                        Rounded Corner of Window Form Application
using System.Runtime.InteropServices;      // Adding in the Library

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]       // Ading this Code
        private static extern IntPtr CreateRoundRectRgn                   // Create A class
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None;                // Using This Code
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));      //Adding This Code
        }
    }
}
