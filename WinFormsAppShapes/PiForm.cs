using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryShapes;

namespace WinFormsAppShapes
{
    public partial class PiForm : Form
    {
        public PiForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При прогрузке формы заполняется таблица с расчетами Пи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PiForm_Load(object sender, EventArgs e)
        {
            //DataGridView dgv = new DataGridView();
            int perimeter = 16;
            int[] countAngles = new int[7];
            double[] piValues = new double[7];
            countAngles[0] = 5; piValues[0] = ClassShapes.piFromPolygonSquare(perimeter, countAngles[0]);
            countAngles[1] = 10; piValues[1] = ClassShapes.piFromPolygonSquare(perimeter, countAngles[1]);
            countAngles[2] = 50; piValues[2] = ClassShapes.piFromPolygonSquare(perimeter, countAngles[2]);
            countAngles[3] = 100; piValues[3] = ClassShapes.piFromPolygonSquare(perimeter, countAngles[3]);
            countAngles[4] = 500; piValues[4] = ClassShapes.piFromPolygonSquare(perimeter, countAngles[4]);
            countAngles[5] = 1000; piValues[5] = ClassShapes.piFromPolygonSquare(perimeter, countAngles[5]);
            countAngles[6] = 10000; piValues[6] = ClassShapes.piFromPolygonSquare(perimeter, countAngles[6]);
            dataGridViewPi.Rows.Add(countAngles[0], piValues[0]);
            dataGridViewPi.Rows.Add(countAngles[1], piValues[1]);
            dataGridViewPi.Rows.Add(countAngles[2], piValues[2]);
            dataGridViewPi.Rows.Add(countAngles[3], piValues[3]);
            dataGridViewPi.Rows.Add(countAngles[4], piValues[4]);
            dataGridViewPi.Rows.Add(countAngles[5], piValues[5]);
            dataGridViewPi.Rows.Add(countAngles[6], piValues[6]);
            //dgv.DataSource = piValues;
            //dgv.Show();
            //dgv.BringToFront();
            //dgv.Visible = true;   
        }

        /// <summary>
        /// Кнопка закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
