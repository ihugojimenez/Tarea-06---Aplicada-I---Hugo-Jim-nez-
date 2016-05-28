namespace WindowsFormsApplication
{
    partial class Ejercicio1
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
            this.Cadenalabel = new System.Windows.Forms.Label();
            this.CadenatextBox = new System.Windows.Forms.TextBox();
            this.Separarbutton = new System.Windows.Forms.Button();
            this.SalidarichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Cadenalabel
            // 
            this.Cadenalabel.AutoSize = true;
            this.Cadenalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadenalabel.Location = new System.Drawing.Point(13, 13);
            this.Cadenalabel.Name = "Cadenalabel";
            this.Cadenalabel.Size = new System.Drawing.Size(112, 16);
            this.Cadenalabel.TabIndex = 0;
            this.Cadenalabel.Text = "Digite la cadena: ";
            // 
            // CadenatextBox
            // 
            this.CadenatextBox.Location = new System.Drawing.Point(16, 41);
            this.CadenatextBox.Name = "CadenatextBox";
            this.CadenatextBox.Size = new System.Drawing.Size(407, 20);
            this.CadenatextBox.TabIndex = 1;
            // 
            // Separarbutton
            // 
            this.Separarbutton.Location = new System.Drawing.Point(189, 77);
            this.Separarbutton.Name = "Separarbutton";
            this.Separarbutton.Size = new System.Drawing.Size(124, 23);
            this.Separarbutton.TabIndex = 2;
            this.Separarbutton.Text = "Separar en lineas";
            this.Separarbutton.UseVisualStyleBackColor = true;
            this.Separarbutton.Click += new System.EventHandler(this.Separarbutton_Click);
            // 
            // SalidarichTextBox
            // 
            this.SalidarichTextBox.Location = new System.Drawing.Point(12, 112);
            this.SalidarichTextBox.Name = "SalidarichTextBox";
            this.SalidarichTextBox.Size = new System.Drawing.Size(122, 180);
            this.SalidarichTextBox.TabIndex = 3;
            this.SalidarichTextBox.Text = "";
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 304);
            this.Controls.Add(this.SalidarichTextBox);
            this.Controls.Add(this.Separarbutton);
            this.Controls.Add(this.CadenatextBox);
            this.Controls.Add(this.Cadenalabel);
            this.Name = "Ejercicio1";
            this.ShowIcon = false;
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cadenalabel;
        private System.Windows.Forms.TextBox CadenatextBox;
        private System.Windows.Forms.Button Separarbutton;
        private System.Windows.Forms.RichTextBox SalidarichTextBox;
    }
}