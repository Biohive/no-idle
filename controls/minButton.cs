using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace no_idle.controls
{
    public class minButton : Button
    {
        public minButton()
        {
            this.Size = new Size(30, 30);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 0, 0, 0);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 0, 0, 0);
            this.BackColor = Color.FromArgb(255, 0, 0, 0);
            this.ForeColor = Color.White;
            this.Font = new Font("Webdings", 12);
            this.Text = "0";
        }
    }
}
