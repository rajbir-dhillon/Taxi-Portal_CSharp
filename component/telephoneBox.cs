using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace component
{
    public partial class telephoneBox : TextBox
    {
        public telephoneBox()
        {
            InitializeComponent();
        }

        public telephoneBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.Text.Length > 11)
            {
                this.ForeColor = Color.Red;
            }
            else
            {
                this.ForeColor = Color.Black;
            }
        }
    }
}
