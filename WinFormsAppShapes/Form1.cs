using ClassLibraryShapes;
namespace WinFormsAppShapes
{
    public partial class FormFermerTask : Form
    {
        public FormFermerTask()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Функция которая заменяет все точки(если они есть) в вводе пользователя на запятые
        /// </summary>
        private void PointsReplacing()
        {
            if (textBoxPerimeter.Text.Contains('.'))
            {
                string newText = "";
                for (int i = 0; i < textBoxPerimeter.Text.Length; i++)
                {
                    if (textBoxPerimeter.Text[i] == '.')
                    {
                        newText += ',';
                    }
                    else
                    {
                        newText += textBoxPerimeter.Text[i];
                    }
                }
                textBoxPerimeter.Text = newText;
            }

        }
        /// <summary>
        /// Функция проверки ввода, при успешном вводе функция возвращает введенный пользователем периметр
        /// Иначе вернет -1
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns name="perimeter"></returns>
        private double ValueCheck(double perimeter)
        {
            try
            {
                perimeter = double.Parse(textBoxPerimeter.Text);
                if (perimeter < 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод. Введите положительное число.", "Ошибка");
                return -1;
            }
            return perimeter;
        }
        /// <summary>
        /// Функция обрабатывающая нажатие кнопки пользователем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFigureSquare_Click(object sender, EventArgs e)
        {
            //При каждом нажатии кнопки вызывается функция заменяющая все точки на запятые
            PointsReplacing();
            if (comboBoxFigure.SelectedItem != null) //Если выбрано значение в выпадающем списке
            {
                double perimeter = 0;
                switch (comboBoxFigure.SelectedItem.ToString()) //Обработка выбранного пункта и проверка ввода периметра. Если все проверки пройдены, то в текстовое поле textBoxSquare записывается полученное значение площади.
                {
                    case ("Квадрат"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.AreaSquare(perimeter).ToString("#.##"));
                        break;
                    case ("Равносторонний треугольник"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.TriangleSquare(perimeter).ToString("#.##"));
                        break;
                    case ("Ромб из 2-х равносторонних треугольников"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.RombSquare(perimeter).ToString("#.##"));
                        break;
                    case ("Прямоугольник"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.Square(perimeter).ToString("#.##"));
                        break;
                    case ("Шестиугольник"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.HexagonSquare(perimeter).ToString("#.##"));
                        break;
                    case ("Круг"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.CircleSquare(perimeter).ToString("#.##"));
                        break;
                }
            }
            else //Если не выбрано значение в выпадающем списке, то выводится предупреждение
            {
                MessageBox.Show("В выпадающем меню не выбрана ни одна фигура.", "Ошибка");
            }
        }
        /// <summary>
        /// Функция открытия модального окна формы с информацией о программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormReference formRef = new FormReference();
            formRef.ShowDialog();
        }
    }
}
