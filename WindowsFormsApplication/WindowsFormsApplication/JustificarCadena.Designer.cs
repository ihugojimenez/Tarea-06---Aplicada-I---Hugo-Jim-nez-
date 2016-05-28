namespace WindowsFormsApplication
{
    partial class JustificarCadena
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
            this.label1 = new System.Windows.Forms.Label();
            this.CadenatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RightradioButton = new System.Windows.Forms.RadioButton();
            this.LeftradioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.EspaciosTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalidatextBox = new System.Windows.Forms.TextBox();
            this.Justificarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cadena:";
            // 
            // CadenatextBox
            // 
            this.CadenatextBox.Location = new System.Drawing.Point(139, 13);
            this.CadenatextBox.Name = "CadenatextBox";
            this.CadenatextBox.Size = new System.Drawing.Size(345, 20);
            this.CadenatextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forma de justificacion:";
            // 
            // RightradioButton
            // 
            this.RightradioButton.AutoSize = true;
            this.RightradioButton.Location = new System.Drawing.Point(13, 109);
            this.RightradioButton.Name = "RightradioButton";
            this.RightradioButton.Size = new System.Drawing.Size(66, 17);
            this.RightradioButton.TabIndex = 3;
            this.RightradioButton.TabStop = true;
            this.RightradioButton.Text = "Derecha";
            this.RightradioButton.UseVisualStyleBackColor = true;
            this.RightradioButton.CheckedChanged += new System.EventHandler(this.RightradioButton_CheckedChanged);
            // 
            // LeftradioButton2
            // 
            this.LeftradioButton2.AutoSize = true;
            this.LeftradioButton2.Location = new System.Drawing.Point(13, 133);
            this.LeftradioButton2.Name = "LeftradioButton2";
            this.LeftradioButton2.Size = new System.Drawing.Size(68, 17);
            this.LeftradioButton2.TabIndex = 4;
            this.LeftradioButton2.TabStop = true;
            this.LeftradioButton2.Text = "Izquierda";
            this.LeftradioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la cantidad de espacios";
            // 
            // EspaciosTextBox
            // 
            this.EspaciosTextBox.Location = new System.Drawing.Point(216, 186);
            this.EspaciosTextBox.Name = "EspaciosTextBox";
            this.EspaciosTextBox.Size = new System.Drawing.Size(85, 20);
            this.EspaciosTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cadena Justificada";
            // 
            // SalidatextBox
            // 
            this.SalidatextBox.Location = new System.Drawing.Point(352, 74);
            this.SalidatextBox.Name = "SalidatextBox";
            this.SalidatextBox.ReadOnly = true;
            this.SalidatextBox.Size = new System.Drawing.Size(196, 20);
            this.SalidatextBox.TabIndex = 8;
            // 
            // Justificarbutton
            // 
            this.Justificarbutton.Location = new System.Drawing.Point(423, 186);
            this.Justificarbutton.Name = "Justificarbutton";
            this.Justificarbutton.Size = new System.Drawing.Size(101, 43);
            this.Justificarbutton.TabIndex = 9;
            this.Justificarbutton.Text = "Justificar Cadena";
            this.Justificarbutton.UseVisualStyleBackColor = true;
            this.Justificarbutton.Click += new System.EventHandler(this.Justificarbutton_Click);
            // 
            // JustificarCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 261);
            this.Controls.Add(this.Justificarbutton);
            this.Controls.Add(this.SalidatextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EspaciosTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LeftradioButton2);
            this.Controls.Add(this.RightradioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CadenatextBox);
            this.Controls.Add(this.label1);
            this.Name = "JustificarCadena";
            this.ShowIcon = false;
            this.Text = "Justificar Cadena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CadenatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RightradioButton;
        private System.Windows.Forms.RadioButton LeftradioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EspaciosTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SalidatextBox;
        private System.Windows.Forms.Button Justificarbutton;
    }
}