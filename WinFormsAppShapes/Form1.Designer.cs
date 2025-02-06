namespace WinFormsAppShapes
{
    partial class FormFermerTask
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFermerTask));
            labelHeader = new Label();
            labelFigureChoice = new Label();
            comboBoxFigure = new ComboBox();
            labelPerimeter = new Label();
            labelSquare = new Label();
            textBoxPerimeter = new TextBox();
            textBoxSquare = new TextBox();
            buttonFigureSquare = new Button();
            buttonInfo = new Button();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(344, 15);
            labelHeader.Margin = new Padding(4, 0, 4, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(247, 38);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Задача фермера";
            // 
            // labelFigureChoice
            // 
            labelFigureChoice.AutoSize = true;
            labelFigureChoice.Font = new Font("Malgun Gothic", 10.8F);
            labelFigureChoice.Location = new Point(31, 78);
            labelFigureChoice.Margin = new Padding(4, 0, 4, 0);
            labelFigureChoice.Name = "labelFigureChoice";
            labelFigureChoice.Size = new Size(199, 30);
            labelFigureChoice.TabIndex = 1;
            labelFigureChoice.Text = "Выберите фигуру:";
            // 
            // comboBoxFigure
            // 
            comboBoxFigure.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFigure.Font = new Font("Malgun Gothic", 9F);
            comboBoxFigure.Items.AddRange(new object[] { "Квадрат", "Равносторонний треугольник", "Ромб из 2-х равносторонних треугольников", "Прямоугольник", "Шестиугольник", "Круг" });
            comboBoxFigure.Location = new Point(248, 80);
            comboBoxFigure.Margin = new Padding(4);
            comboBoxFigure.Name = "comboBoxFigure";
            comboBoxFigure.Size = new Size(485, 33);
            comboBoxFigure.TabIndex = 2;
            // 
            // labelPerimeter
            // 
            labelPerimeter.AutoSize = true;
            labelPerimeter.Font = new Font("Malgun Gothic", 10.8F);
            labelPerimeter.Location = new Point(31, 139);
            labelPerimeter.Margin = new Padding(4, 0, 4, 0);
            labelPerimeter.Name = "labelPerimeter";
            labelPerimeter.Size = new Size(207, 30);
            labelPerimeter.TabIndex = 3;
            labelPerimeter.Text = "Периметр фигуры:";
            // 
            // labelSquare
            // 
            labelSquare.AutoSize = true;
            labelSquare.Font = new Font("Malgun Gothic", 10.8F);
            labelSquare.Location = new Point(31, 199);
            labelSquare.Margin = new Padding(4, 0, 4, 0);
            labelSquare.Name = "labelSquare";
            labelSquare.Size = new Size(196, 30);
            labelSquare.TabIndex = 4;
            labelSquare.Text = "Площадь фигуры:";
            // 
            // textBoxPerimeter
            // 
            textBoxPerimeter.Font = new Font("Malgun Gothic", 9F);
            textBoxPerimeter.Location = new Point(255, 141);
            textBoxPerimeter.Margin = new Padding(4);
            textBoxPerimeter.Name = "textBoxPerimeter";
            textBoxPerimeter.Size = new Size(478, 31);
            textBoxPerimeter.TabIndex = 5;
            // 
            // textBoxSquare
            // 
            textBoxSquare.Font = new Font("Malgun Gothic", 9F);
            textBoxSquare.Location = new Point(242, 201);
            textBoxSquare.Margin = new Padding(4);
            textBoxSquare.Name = "textBoxSquare";
            textBoxSquare.ReadOnly = true;
            textBoxSquare.Size = new Size(490, 31);
            textBoxSquare.TabIndex = 6;
            // 
            // buttonFigureSquare
            // 
            buttonFigureSquare.Font = new Font("Malgun Gothic", 9F);
            buttonFigureSquare.Location = new Point(758, 101);
            buttonFigureSquare.Margin = new Padding(4);
            buttonFigureSquare.Name = "buttonFigureSquare";
            buttonFigureSquare.Size = new Size(152, 90);
            buttonFigureSquare.TabIndex = 1;
            buttonFigureSquare.Text = "Расчитать площадь фигуры";
            buttonFigureSquare.UseVisualStyleBackColor = true;
            buttonFigureSquare.Click += buttonFigureSquare_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = SystemColors.ControlLightLight;
            buttonInfo.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInfo.FlatAppearance.BorderSize = 0;
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.Location = new Point(15, 6);
            buttonInfo.Margin = new Padding(4);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(42, 48);
            buttonInfo.TabIndex = 8;
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormFermerTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 285);
            Controls.Add(buttonInfo);
            Controls.Add(buttonFigureSquare);
            Controls.Add(textBoxSquare);
            Controls.Add(textBoxPerimeter);
            Controls.Add(labelSquare);
            Controls.Add(labelPerimeter);
            Controls.Add(comboBoxFigure);
            Controls.Add(labelFigureChoice);
            Controls.Add(labelHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormFermerTask";
            Text = "Задача фермера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private Label labelFigureChoice;
        private ComboBox comboBoxFigure;
        private Label labelPerimeter;
        private Label labelSquare;
        private TextBox textBoxPerimeter;
        private TextBox textBoxSquare;
        private Button buttonFigureSquare;
        private Button buttonInfo;
    }
}
