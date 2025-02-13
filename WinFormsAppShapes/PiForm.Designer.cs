namespace WinFormsAppShapes
{
    partial class PiForm
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
            components = new System.ComponentModel.Container();
            dataGridViewPi = new DataGridView();
            CountAngles = new DataGridViewTextBoxColumn();
            PiValue = new DataGridViewTextBoxColumn();
            piFormBindingSource = new BindingSource(components);
            piFormBindingSource1 = new BindingSource(components);
            buttonClose = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piFormBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piFormBindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPi
            // 
            dataGridViewPi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewPi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPi.BorderStyle = BorderStyle.None;
            dataGridViewPi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPi.Columns.AddRange(new DataGridViewColumn[] { CountAngles, PiValue });
            dataGridViewPi.Dock = DockStyle.Fill;
            dataGridViewPi.Location = new Point(0, 0);
            dataGridViewPi.Name = "dataGridViewPi";
            dataGridViewPi.RowHeadersWidth = 51;
            dataGridViewPi.Size = new Size(800, 450);
            dataGridViewPi.TabIndex = 0;
            // 
            // CountAngles
            // 
            CountAngles.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CountAngles.HeaderText = "Количество углов";
            CountAngles.MinimumWidth = 6;
            CountAngles.Name = "CountAngles";
            // 
            // PiValue
            // 
            PiValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PiValue.HeaderText = "Значение Пи";
            PiValue.MinimumWidth = 6;
            PiValue.Name = "PiValue";
            // 
            // piFormBindingSource
            // 
            piFormBindingSource.DataSource = typeof(PiForm);
            // 
            // piFormBindingSource1
            // 
            piFormBindingSource1.DataSource = typeof(PiForm);
            // 
            // buttonClose
            // 
            buttonClose.Dock = DockStyle.Right;
            buttonClose.Location = new Point(693, 1);
            buttonClose.Margin = new Padding(5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(106, 59);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(buttonClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 389);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(800, 61);
            panel1.TabIndex = 2;
            // 
            // PiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPi);
            Name = "PiForm";
            Text = "Таблица расчетов числа Пи";
            Load += PiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPi).EndInit();
            ((System.ComponentModel.ISupportInitialize)piFormBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)piFormBindingSource1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPi;
        private BindingSource piFormBindingSource;
        private BindingSource piFormBindingSource1;
        private Button buttonClose;
        private Panel panel1;
        private DataGridViewTextBoxColumn CountAngles;
        private DataGridViewTextBoxColumn PiValue;
    }
}