using System;
using System.Drawing;
using System.Windows.Forms;
using CustomScrollBar;

namespace GUI {
    public partial class Window : Form {
        public Window()
        {
            InitializeComponent();

            ScrollPanel panel = new ScrollPanel();
            panel.Dock = DockStyle.Fill;
            panel.BackColor = Color.FromArgb(50, 50, 50);

            Controls.Add(panel);
        }
    }
}
