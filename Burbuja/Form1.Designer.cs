namespace Burbuja
{
    partial class Form1
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
            label1 = new Label();
            buttnAgregar = new Button();
            tbNumber = new TextBox();
            listBoxnumber = new ListBox();
            btnSort = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 45);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Numero";
            // 
            // buttnAgregar
            // 
            buttnAgregar.Location = new Point(439, 45);
            buttnAgregar.Name = "buttnAgregar";
            buttnAgregar.Size = new Size(75, 23);
            buttnAgregar.TabIndex = 2;
            buttnAgregar.Text = "Agregar";
            buttnAgregar.UseVisualStyleBackColor = true;
            buttnAgregar.Click += buttnAgregar_Click;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(297, 34);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(100, 23);
            tbNumber.TabIndex = 3;
            // 
            // listBoxnumber
            // 
            listBoxnumber.FormattingEnabled = true;
            listBoxnumber.ItemHeight = 15;
            listBoxnumber.Location = new Point(261, 120);
            listBoxnumber.Name = "listBoxnumber";
            listBoxnumber.Size = new Size(233, 214);
            listBoxnumber.TabIndex = 4;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(552, 45);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 5;
            btnSort.Text = "Ordenar";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSort);
            Controls.Add(listBoxnumber);
            Controls.Add(tbNumber);
            Controls.Add(buttnAgregar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttnAgregar;
        private TextBox tbNumber;
        private ListBox listBoxnumber;
        private Button btnSort;
    }
}
