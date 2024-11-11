namespace Nuevo_Proyecto
{
    partial class Register
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
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 102);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 24;
            label3.Text = "Confirmar contraseña:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 73);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 22;
            label4.Text = "Contraseña:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(91, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 23);
            textBox4.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(103, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 19;
            label2.Text = "Correo:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 17;
            label1.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 16;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 181);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
    }
}