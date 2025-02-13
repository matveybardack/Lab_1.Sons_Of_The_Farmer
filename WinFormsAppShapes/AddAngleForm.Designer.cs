namespace WinFormsAppShapes
{
    partial class FormNewAngle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAngleAdd = new Button();
            textBoxNewAngle = new TextBox();
            labelNewAngles = new Label();
            SuspendLayout();
            // 
            // buttonAngleAdd
            // 
            buttonAngleAdd.Font = new Font("Malgun Gothic", 13.8F);
            buttonAngleAdd.Location = new Point(432, 164);
            buttonAngleAdd.Name = "buttonAngleAdd";
            buttonAngleAdd.Size = new Size(133, 44);
            buttonAngleAdd.TabIndex = 0;
            buttonAngleAdd.Text = "Добавить";
            buttonAngleAdd.UseVisualStyleBackColor = true;
            buttonAngleAdd.Click += buttonAngleAdd_Click;
            // 
            // textBoxNewAngle
            // 
            textBoxNewAngle.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNewAngle.Location = new Point(33, 84);
            textBoxNewAngle.Name = "textBoxNewAngle";
            textBoxNewAngle.Size = new Size(446, 38);
            textBoxNewAngle.TabIndex = 1;
            // 
            // labelNewAngles
            // 
            labelNewAngles.AutoSize = true;
            labelNewAngles.Font = new Font("Malgun Gothic", 13.8F);
            labelNewAngles.Location = new Point(33, 9);
            labelNewAngles.Name = "labelNewAngles";
            labelNewAngles.Size = new Size(409, 62);
            labelNewAngles.TabIndex = 2;
            labelNewAngles.Text = "Введите количество углов, которое \r\nбудет добавлено в список:";
            // 
            // FormNewAngle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 232);
            Controls.Add(labelNewAngles);
            Controls.Add(textBoxNewAngle);
            Controls.Add(buttonAngleAdd);
            Name = "FormNewAngle";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAngleAdd;
        private TextBox textBoxNewAngle;
        private Label labelNewAngles;
    }
}