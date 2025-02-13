namespace WinFormsAppShapes
{
    partial class FormError
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
            labelError = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Malgun Gothic", 13.8F);
            labelError.Location = new Point(22, 20);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 31);
            labelError.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(421, 125);
            button1.Name = "button1";
            button1.Size = new Size(77, 40);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormError
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 177);
            Controls.Add(button1);
            Controls.Add(labelError);
            Name = "FormError";
            Text = "Ошибка";
            Load += FormError_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelError;
        private Button button1;
    }
}