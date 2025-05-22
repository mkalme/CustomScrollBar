using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomScrollBar {
    public class ScrollPanel : Panel{
        private Panel ContentPanel { get; set; }
        public new ControlCollection Controls {
            get { return ContentPanel.Controls; }
        }

        public ScrollPanel() {
            ContentPanel = new Panel();
            ContentPanel.AutoSize = true;
            ContentPanel.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);

            Button button = new Button();
            button.AutoSize = true;
            Controls.Add(button);

            ContentPanel.Padding = new Padding(0);
            ContentPanel.Margin = new Padding(0);

            base.Controls.Add(ContentPanel);
        }
    }
}
