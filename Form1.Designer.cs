namespace ejerciciopractico
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
            this.labelcedula = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.entrycc = new System.Windows.Forms.TextBox();
            this.entrynom = new System.Windows.Forms.TextBox();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.anuncio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelcedula
            // 
            this.labelcedula.AutoSize = true;
            this.labelcedula.Location = new System.Drawing.Point(40, 61);
            this.labelcedula.Name = "labelcedula";
            this.labelcedula.Size = new System.Drawing.Size(44, 15);
            this.labelcedula.TabIndex = 0;
            this.labelcedula.Text = "Cedula";
            this.labelcedula.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(40, 111);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(51, 15);
            this.labelnombre.TabIndex = 1;
            this.labelnombre.Text = "Nombre";
            this.labelnombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // entrycc
            // 
            this.entrycc.Location = new System.Drawing.Point(97, 53);
            this.entrycc.Name = "entrycc";
            this.entrycc.Size = new System.Drawing.Size(100, 23);
            this.entrycc.TabIndex = 2;
            // 
            // entrynom
            // 
            this.entrynom.Location = new System.Drawing.Point(97, 103);
            this.entrynom.Name = "entrynom";
            this.entrynom.Size = new System.Drawing.Size(100, 23);
            this.entrynom.TabIndex = 3;
            this.entrynom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Location = new System.Drawing.Point(40, 9);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(111, 15);
            this.labeltitulo.TabIndex = 4;
            this.labeltitulo.Text = "Registro Empleados";
            this.labeltitulo.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(40, 154);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.addempleado);
            // 
            // anuncio
            // 
            this.anuncio.AutoSize = true;
            this.anuncio.Location = new System.Drawing.Point(40, 194);
            this.anuncio.Name = "anuncio";
            this.anuncio.Size = new System.Drawing.Size(10, 15);
            this.anuncio.TabIndex = 7;
            this.anuncio.Text = " ";
            this.anuncio.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 229);
            this.Controls.Add(this.anuncio);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.entrynom);
            this.Controls.Add(this.entrycc);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelcedula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelcedula;
        private Label labelnombre;
        private TextBox entrycc;
        private TextBox entrynom;
        private Label labeltitulo;
        private Button btnguardar;
        private Label anuncio;
    }
}