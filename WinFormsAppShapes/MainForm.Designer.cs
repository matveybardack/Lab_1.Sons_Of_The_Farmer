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
            labelNumAngles = new Label();
            comboBoxAngles = new ComboBox();
            buttonPiNUgol = new Button();
            textBoxPiNUgol = new TextBox();
            labelPiNUgol = new Label();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Malgun Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(275, 12);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(247, 38);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Задача фермера";
            // 
            // labelFigureChoice
            // 
            labelFigureChoice.AutoSize = true;
            labelFigureChoice.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFigureChoice.Location = new Point(22, 77);
            labelFigureChoice.Name = "labelFigureChoice";
            labelFigureChoice.Size = new Size(208, 31);
            labelFigureChoice.TabIndex = 1;
            labelFigureChoice.Text = "Выберите фигуру:";
            // 
            // comboBoxFigure
            // 
            comboBoxFigure.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFigure.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxFigure.Items.AddRange(new object[] { "Квадрат", "Равносторонний треугольник", "Ромб из 2-х равносторонних треугольников", "Прямоугольник", "Шестиугольник", "Круг", "N-угольник" });
            comboBoxFigure.Location = new Point(242, 77);
            comboBoxFigure.Name = "comboBoxFigure";
            comboBoxFigure.Size = new Size(383, 39);
            comboBoxFigure.TabIndex = 2;
            comboBoxFigure.SelectionChangeCommitted += comboBoxFigure_SelectionChangeCommitted;
            // 
            // labelPerimeter
            // 
            labelPerimeter.AutoSize = true;
            labelPerimeter.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPerimeter.Location = new Point(13, 134);
            labelPerimeter.Name = "labelPerimeter";
            labelPerimeter.Size = new Size(217, 31);
            labelPerimeter.TabIndex = 3;
            labelPerimeter.Text = "Периметр фигуры:";
            // 
            // labelSquare
            // 
            labelSquare.AutoSize = true;
            labelSquare.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSquare.Location = new Point(23, 193);
            labelSquare.Name = "labelSquare";
            labelSquare.Size = new Size(207, 31);
            labelSquare.TabIndex = 4;
            labelSquare.Text = "Площадь фигуры:";
            // 
            // textBoxPerimeter
            // 
            textBoxPerimeter.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPerimeter.Location = new Point(242, 134);
            textBoxPerimeter.Name = "textBoxPerimeter";
            textBoxPerimeter.Size = new Size(383, 38);
            textBoxPerimeter.TabIndex = 5;
            // 
            // textBoxSquare
            // 
            textBoxSquare.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSquare.Location = new Point(242, 190);
            textBoxSquare.Name = "textBoxSquare";
            textBoxSquare.ReadOnly = true;
            textBoxSquare.Size = new Size(383, 38);
            textBoxSquare.TabIndex = 6;
            // 
            // buttonFigureSquare
            // 
            buttonFigureSquare.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFigureSquare.Location = new Point(660, 190);
            buttonFigureSquare.Name = "buttonFigureSquare";
            buttonFigureSquare.Size = new Size(163, 117);
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
            buttonInfo.Location = new Point(12, 5);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(34, 38);
            buttonInfo.TabIndex = 8;
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // labelNumAngles
            // 
            labelNumAngles.AutoSize = true;
            labelNumAngles.Font = new Font("Malgun Gothic", 13.8F);
            labelNumAngles.Location = new Point(660, 77);
            labelNumAngles.Name = "labelNumAngles";
            labelNumAngles.Size = new Size(323, 31);
            labelNumAngles.TabIndex = 9;
            labelNumAngles.Text = "Выберите количество углов:";
            labelNumAngles.Visible = false;
            // 
            // comboBoxAngles
            // 
            comboBoxAngles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAngles.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxAngles.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "Другое значение" });
            comboBoxAngles.Location = new Point(660, 126);
            comboBoxAngles.Name = "comboBoxAngles";
            comboBoxAngles.Size = new Size(221, 39);
            comboBoxAngles.TabIndex = 10;
            comboBoxAngles.Visible = false;
            comboBoxAngles.SelectionChangeCommitted += comboBoxAngles_SelectedIndexChanged;
            // 
            // buttonPiNUgol
            // 
            buttonPiNUgol.Font = new Font("Malgun Gothic", 13.8F);
            buttonPiNUgol.Location = new Point(829, 190);
            buttonPiNUgol.Name = "buttonPiNUgol";
            buttonPiNUgol.Size = new Size(158, 117);
            buttonPiNUgol.TabIndex = 11;
            buttonPiNUgol.Text = "Таблица расчетов числа Пи";
            buttonPiNUgol.UseVisualStyleBackColor = true;
            buttonPiNUgol.Visible = false;
            buttonPiNUgol.Click += buttonPiNUgol_Click;
            // 
            // textBoxPiNUgol
            // 
            textBoxPiNUgol.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPiNUgol.Location = new Point(242, 245);
            textBoxPiNUgol.Name = "textBoxPiNUgol";
            textBoxPiNUgol.ReadOnly = true;
            textBoxPiNUgol.Size = new Size(383, 38);
            textBoxPiNUgol.TabIndex = 12;
            textBoxPiNUgol.Visible = false;
            // 
            // labelPiNUgol
            // 
            labelPiNUgol.AutoSize = true;
            labelPiNUgol.Font = new Font("Malgun Gothic", 13.8F);
            labelPiNUgol.Location = new Point(180, 248);
            labelPiNUgol.Name = "labelPiNUgol";
            labelPiNUgol.Size = new Size(50, 31);
            labelPiNUgol.TabIndex = 13;
            labelPiNUgol.Text = "Пи:";
            labelPiNUgol.Visible = false;
            // 
            // FormFermerTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 372);
            Controls.Add(labelPiNUgol);
            Controls.Add(textBoxPiNUgol);
            Controls.Add(buttonPiNUgol);
            Controls.Add(comboBoxAngles);
            Controls.Add(labelNumAngles);
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
        private Label labelNumAngles;
        private ComboBox comboBoxAngles;
        private Button buttonPiNUgol;
        private TextBox textBoxPiNUgol;
        private Label labelPiNUgol;
    }
}
