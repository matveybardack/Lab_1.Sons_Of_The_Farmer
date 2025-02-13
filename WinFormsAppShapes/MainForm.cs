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
                string errorText = "Неверный ввод. \nВведите положительное число.";
                FormError formError = new FormError(errorText);
                formError.ShowDialog();
                return -1;
            }
            return perimeter;
        }

        /// <summary>
        /// Функция создающая новый отсортированный массив данных в комбобоксе с углами
        /// </summary>
        /// <param name="sides"></param>
        /// <returns></returns>
        private string[] newItemList(int sides)
        {
            int k = 0, finalLength = comboBoxAngles.Items.Count + 1;
            string[] items = new string[finalLength];
            for (int i = 0; i < finalLength; i++)
            {
                if (sides == i)
                {
                    finalLength -= 1;
                }
                if (comboBoxAngles.Items[i].ToString() != "Другое значение" && Convert.ToInt32(comboBoxAngles.Items[i]) <= sides)
                {
                    items[i] = comboBoxAngles.Items[i].ToString();
                }
                else
                {
                    k = i + 1;
                    items[i] = sides.ToString();
                    break;
                }
            }

            for (int i = k; i < finalLength; i++)
                items[i] = comboBoxAngles.Items[i - 1].ToString();

            return items;
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
                double perimeter = 0; int sides;
                switch (comboBoxFigure.SelectedItem.ToString()) //Обработка выбранного пункта и проверка ввода периметра. Если все проверки пройдены, то в текстовое поле textBoxSquare записывается полученное значение площади.
                {
                    case ("Квадрат"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.AreaSquare(perimeter).ToString("#.###"));
                        break;
                    case ("Равносторонний треугольник"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.TriangleSquare(perimeter).ToString("#.###"));
                        break;
                    case ("Ромб из 2-х равносторонних треугольников"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.RombSquare(perimeter).ToString("#.###"));
                        break;
                    case ("Прямоугольник"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.Square(perimeter).ToString("#.###"));
                        break;
                    case ("Шестиугольник"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.HexagonSquare(perimeter).ToString("#.###"));
                        break;
                    case ("Круг"):
                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                            textBoxSquare.Text = (ClassShapes.CircleSquare(perimeter).ToString("#.###"));
                        break;
                    case ("N-угольник"):
                        if (comboBoxAngles.SelectedItem == null)
                        {
                            string errorText = "Не выбрано количество углов";
                            FormError formError = new FormError(errorText);
                            formError.ShowDialog();
                            return;
                        }
                        else
                            sides = Convert.ToInt32(comboBoxAngles.SelectedItem.ToString());

                        perimeter = ValueCheck(perimeter);
                        if (perimeter >= 0)
                        {
                            textBoxSquare.Text = (ClassShapes.PolygonSquare(perimeter, sides).ToString("#.###"));
                            textBoxPiNUgol.Text = (ClassShapes.piFromPolygonSquare(perimeter, sides).ToString("#.########"));
                        }
                        break;

                }
            }
            else //Если не выбрано значение в выпадающем списке, то выводится предупреждение
            {
                string errorText = "В выпадающем меню не выбрана \nни одна фигура.";
                FormError formError = new FormError(errorText);
                formError.ShowDialog();
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

        /// <summary>
        /// Событие выбора количества углов. При выборе поля "Другое значение" - открывается модальное окно с вводом нового значения, которое добавляется в список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAngles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newItem;
            if (comboBoxAngles.SelectedItem.ToString() == "Другое значение")
            {
                FormNewAngle newAngle = new FormNewAngle();
                newAngle.ShowDialog();
                newItem = newAngle.newAngleInt;
                string[] newItems = new string[comboBoxAngles.Items.Count + 1];
                newItems = newItemList(newItem);
                comboBoxAngles.Items.Clear();
                comboBoxAngles.Items.AddRange(newItems);
                comboBoxAngles.SelectedItem = newItem;
            }
        }
        /// <summary>
        /// Функция скрывающая и покащывающая элементы интерфейса связанные с N-угольником
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFigure_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxFigure.SelectedItem.ToString() == "N-угольник")
            {
                labelNumAngles.Visible = true;
                comboBoxAngles.Visible = true;
                labelPiNUgol.Visible = true;
                textBoxPiNUgol.Visible = true;
                buttonPiNUgol.Visible = true;
            }
            else
            {
                labelNumAngles.Visible = false;
                comboBoxAngles.Visible = false;
                labelPiNUgol.Visible = false;
                textBoxPiNUgol.Visible = false;
                buttonPiNUgol.Visible = false;
            }
        }

        /// <summary>
        /// Открытие таблицы значений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPiNUgol_Click(object sender, EventArgs e)
        {
            PiForm PiForm = new PiForm();
            PiForm.ShowDialog();
        }
    }
}
