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
    public partial class FormNewAngle : Form
    {
        public FormNewAngle()
        {
            InitializeComponent();
        }

        public int newAngleInt;
        /// <summary>
        /// Форма для ввода угла. Сразу при вводе происходит проверка количества введенных углов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAngleAdd_Click(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    newAngleInt = int.Parse(textBoxNewAngle.Text);
                    if (newAngleInt < 3)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    string errorText = "Неверный ввод. \nВведите целое положительное число > 2.";
                    FormError formError = new FormError(errorText);
                    formError.ShowDialog();
                    return;
                }
                break;
            }
            this.Close();
        }
    }
}
