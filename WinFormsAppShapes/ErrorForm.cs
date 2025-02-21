using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppShapes
{
    /// <summary>
    /// Форма, являющаяся основой для сообщений об ошибках
    /// </summary>
    public partial class FormError : Form
    {
        public string error;
        public FormError(string errorText)
        {
            InitializeComponent();
            error = errorText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FormError_Load(object sender, EventArgs e)
        {
            labelError.Text = error;
        }
    }
}
