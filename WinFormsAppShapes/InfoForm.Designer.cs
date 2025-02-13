namespace WinFormsAppShapes
{
    partial class FormReference
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
            labelHead = new Label();
            labelBody = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelHead
            // 
            labelHead.AutoSize = true;
            labelHead.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHead.Location = new Point(228, 9);
            labelHead.Name = "labelHead";
            labelHead.Size = new Size(176, 28);
            labelHead.TabIndex = 0;
            labelHead.Text = "Задача фермера";
            // 
            // labelBody
            // 
            labelBody.AutoSize = true;
            labelBody.Font = new Font("Malgun Gothic", 10.8F);
            labelBody.Location = new Point(13, 44);
            labelBody.Name = "labelBody";
            labelBody.Size = new Size(0, 25);
            labelBody.TabIndex = 1;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Malgun Gothic", 10.8F);
            buttonClose.Location = new Point(172, 285);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(288, 42);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Закрыть окно";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormReference
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 349);
            Controls.Add(buttonClose);
            Controls.Add(labelBody);
            Controls.Add(labelHead);
            Name = "FormReference";
            Text = "Справка";
            Load += FormReference_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHead;
        private Label labelBody;
        private Button buttonClose;
    }
}