namespace GIT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chk_A = new System.Windows.Forms.CheckBox();
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Form1 = new System.Windows.Forms.Label();
            this.chk_B = new System.Windows.Forms.CheckBox();
            this.chk_C = new System.Windows.Forms.CheckBox();
            this.chk_D = new System.Windows.Forms.CheckBox();
            this.btn_Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_A
            // 
            this.chk_A.AutoSize = true;
            this.chk_A.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_A.Location = new System.Drawing.Point(269, 196);
            this.chk_A.Name = "chk_A";
            this.chk_A.Size = new System.Drawing.Size(449, 22);
            this.chk_A.TabIndex = 2;
            this.chk_A.Text = "A -  Entender por que el ser humano es tan complejo. ";
            this.chk_A.UseVisualStyleBackColor = true;
            this.chk_A.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Siguiente.Location = new System.Drawing.Point(624, 350);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(94, 38);
            this.btn_Siguiente.TabIndex = 6;
            this.btn_Siguiente.Text = "Siguiente";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            this.btn_Siguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(652, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 217);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Titulo.Location = new System.Drawing.Point(334, 46);
            this.lbl_Titulo.MaximumSize = new System.Drawing.Size(250, 250);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(215, 24);
            this.lbl_Titulo.TabIndex = 10;
            this.lbl_Titulo.Text = "TEST VOCACIONAL";
            this.lbl_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Form1
            // 
            this.lbl_Form1.AutoSize = true;
            this.lbl_Form1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Form1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Form1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider1.SetIconAlignment(this.lbl_Form1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.lbl_Form1.Location = new System.Drawing.Point(313, 101);
            this.lbl_Form1.MaximumSize = new System.Drawing.Size(250, 250);
            this.lbl_Form1.Name = "lbl_Form1";
            this.lbl_Form1.Size = new System.Drawing.Size(248, 54);
            this.lbl_Form1.TabIndex = 11;
            this.lbl_Form1.Text = "Si te concedieran un deseo relacionado al conocimiento... Que pedirias?";
            this.lbl_Form1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Form1.UseMnemonic = false;
            this.lbl_Form1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // chk_B
            // 
            this.chk_B.AutoSize = true;
            this.chk_B.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_B.Location = new System.Drawing.Point(269, 224);
            this.chk_B.Name = "chk_B";
            this.chk_B.Size = new System.Drawing.Size(438, 22);
            this.chk_B.TabIndex = 12;
            this.chk_B.Text = "B - Saber las leyes abstractas que rigen al universo ";
            this.chk_B.UseVisualStyleBackColor = true;
            this.chk_B.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // chk_C
            // 
            this.chk_C.AutoSize = true;
            this.chk_C.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_C.Location = new System.Drawing.Point(269, 252);
            this.chk_C.Name = "chk_C";
            this.chk_C.Size = new System.Drawing.Size(391, 22);
            this.chk_C.TabIndex = 13;
            this.chk_C.Text = "C - Inventar las mejores tecnologías del futuro";
            this.chk_C.UseVisualStyleBackColor = true;
            // 
            // chk_D
            // 
            this.chk_D.AutoSize = true;
            this.chk_D.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_D.Location = new System.Drawing.Point(269, 280);
            this.chk_D.Name = "chk_D";
            this.chk_D.Size = new System.Drawing.Size(381, 22);
            this.chk_D.TabIndex = 14;
            this.chk_D.Text = "D - Ver todas las cosas hermosas del mundo ";
            this.chk_D.UseVisualStyleBackColor = true;
            // 
            // btn_Atras
            // 
            this.btn_Atras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atras.Location = new System.Drawing.Point(205, 350);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(94, 38);
            this.btn_Atras.TabIndex = 15;
            this.btn_Atras.Text = "Atras";
            this.btn_Atras.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 474);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.chk_D);
            this.Controls.Add(this.chk_C);
            this.Controls.Add(this.chk_B);
            this.Controls.Add(this.lbl_Form1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Siguiente);
            this.Controls.Add(this.chk_A);
            this.Name = "Form1";
            this.Text = "TEST VOCACIONAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chk_A;
        private System.Windows.Forms.Button btn_Siguiente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Form1;
        private System.Windows.Forms.CheckBox chk_D;
        private System.Windows.Forms.CheckBox chk_C;
        private System.Windows.Forms.CheckBox chk_B;
        private System.Windows.Forms.Button btn_Atras;
    }
}

