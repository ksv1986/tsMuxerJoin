using System;
using System.Windows.Forms;

namespace tsMuxerJoin
{
    public partial class PreviewForm : Form
    {
        public PreviewForm(string text)
        {
            InitializeComponent();
            meta.Text = text;
        }
    }
}
