namespace Search_algorithms
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
            btnGenerate = new Button();
            label1 = new Label();
            textBoxBuscar = new TextBox();
            cmbMethods = new ComboBox();
            lstbNumber = new ListBox();
            btnSearch = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(178, 95);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter a number";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(106, 53);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(100, 23);
            textBoxBuscar.TabIndex = 2;
            // 
            // cmbMethods
            // 
            cmbMethods.FormattingEnabled = true;
            cmbMethods.Location = new Point(216, 53);
            cmbMethods.Name = "cmbMethods";
            cmbMethods.Size = new Size(121, 23);
            cmbMethods.TabIndex = 3;
            // 
            // lstbNumber
            // 
            lstbNumber.FormattingEnabled = true;
            lstbNumber.ItemHeight = 15;
            lstbNumber.Location = new Point(358, 53);
            lstbNumber.Name = "lstbNumber";
            lstbNumber.Size = new Size(90, 304);
            lstbNumber.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(178, 124);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnBuscar_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(12, 175);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(89, 15);
            labelResultado.TabIndex = 6;
            labelResultado.Text = "labelResultados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado);
            Controls.Add(btnSearch);
            Controls.Add(lstbNumber);
            Controls.Add(cmbMethods);
            Controls.Add(textBoxBuscar);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Label label1;
        private TextBox textBoxBuscar;
        private ComboBox cmbMethods;
        private ListBox lstbNumber;
        private Button btnSearch;
        private Label labelResultado;
    }
}
