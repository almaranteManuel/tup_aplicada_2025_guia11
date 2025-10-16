namespace GeometriaDesktop
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
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            button1 = new Button();
            tbArea = new TextBox();
            tbRadio = new TextBox();
            tbAlto = new TextBox();
            tbAncho = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            rbCirculo = new RadioButton();
            rbRectangulo = new RadioButton();
            groupBox2 = new GroupBox();
            lvwFiguras = new ListView();
            button4 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbArea);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(tbAlto);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la figura";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(518, 95);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 60);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Confirmar Registro";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(518, 19);
            button1.Name = "button1";
            button1.Size = new Size(75, 60);
            button1.TabIndex = 9;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(358, 133);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(100, 23);
            tbArea.TabIndex = 8;
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(358, 95);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(100, 23);
            tbRadio.TabIndex = 7;
            // 
            // tbAlto
            // 
            tbAlto.Location = new Point(358, 56);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(100, 23);
            tbAlto.TabIndex = 6;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(358, 19);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 23);
            tbAncho.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 136);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Area";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 98);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 59);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Alto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 22);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Ancho";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbCirculo);
            groupBox3.Controls.Add(rbRectangulo);
            groupBox3.Location = new Point(20, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tipo de Figura";
            // 
            // rbCirculo
            // 
            rbCirculo.AutoSize = true;
            rbCirculo.Location = new Point(6, 47);
            rbCirculo.Name = "rbCirculo";
            rbCirculo.Size = new Size(63, 19);
            rbCirculo.TabIndex = 1;
            rbCirculo.TabStop = true;
            rbCirculo.Text = "Circulo";
            rbCirculo.UseVisualStyleBackColor = true;
            rbCirculo.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rbRectangulo
            // 
            rbRectangulo.AutoSize = true;
            rbRectangulo.Location = new Point(6, 22);
            rbRectangulo.Name = "rbRectangulo";
            rbRectangulo.Size = new Size(85, 19);
            rbRectangulo.TabIndex = 0;
            rbRectangulo.TabStop = true;
            rbRectangulo.Text = "Rectangulo";
            rbRectangulo.UseVisualStyleBackColor = true;
            rbRectangulo.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvwFiguras);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(12, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(646, 216);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de Figuras";
            // 
            // lvwFiguras
            // 
            lvwFiguras.Location = new Point(6, 22);
            lvwFiguras.Name = "lvwFiguras";
            lvwFiguras.Size = new Size(452, 188);
            lvwFiguras.TabIndex = 12;
            lvwFiguras.UseCompatibleStateImageBehavior = false;
            // 
            // button4
            // 
            button4.Location = new Point(518, 129);
            button4.Name = "button4";
            button4.Size = new Size(75, 60);
            button4.TabIndex = 11;
            button4.Text = "Eliminar Registro";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(518, 45);
            button3.Name = "button3";
            button3.Size = new Size(75, 60);
            button3.TabIndex = 10;
            button3.Text = "Actualizar Listado";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 502);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private RadioButton rbCirculo;
        private RadioButton rbRectangulo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRegistrar;
        private Button button1;
        private TextBox tbArea;
        private TextBox tbRadio;
        private TextBox tbAlto;
        private TextBox tbAncho;
        private Button button4;
        private Button button3;
        private ListView lvwFiguras;
    }
}
