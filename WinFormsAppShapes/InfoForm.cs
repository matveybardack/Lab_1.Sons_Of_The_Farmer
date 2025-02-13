using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Форма с информацией о программе
namespace WinFormsAppShapes
{
    public partial class FormReference : Form
    {
        public FormReference()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReference_Load(object sender, EventArgs e)
        {
            labelBody.Text = "    Фермер хочет сделать ограду для своего участка в ввиде\nгеометрической фигуры.Он знает периметр этой фигуры, \nнадо рассчитать площадь полученной фигуры.\n    Инструкция пользвания:\n1.Выберите нужную фигуру в выпадающем меню\n2.В текстовое поле введите периметр фигуры в числовом формате\n3.Нажмите кнопку 'Вычислить площадь фигуры'\n4.Вычесленная площадь отобразится в поле рядом с надписью\n'Площадь фигуры'";
        }
    }
}
