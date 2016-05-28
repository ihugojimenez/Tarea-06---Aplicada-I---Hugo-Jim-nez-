namespace WindowsFormsApplication
{
    partial class Ordenar
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
            this.CadenastextBox = new System.Windows.Forms.TextBox();
            this.Ordenarbutton = new System.Windows.Forms.Button();
            this.SalidarichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite las cadenas";
            // 
            // CadenastextBox
            // 
            this.CadenastextBox.Location = new System.Drawing.Point(140, 13);
            this.CadenastextBox.Name = "CadenastextBox";
            this.CadenastextBox.Size = new System.Drawing.Size(335, 20);
            this.CadenastextBox.TabIndex = 1;
            // 
            // Ordenarbutton
            // 
            this.Ordenarbutton.Location = new System.Drawing.Point(195, 60);
            this.Ordenarbutton.Name = "Ordenarbutton";
            this.Ordenarbutton.Size = new System.Drawing.Size(75, 23);
            this.Ordenarbutton.TabIndex = 2;
            this.Ordenarbutton.Text = "Ordenar";
            this.Ordenarbutton.UseVisualStyleBackColor = true;
            this.Ordenarbutton.Click += new System.EventHandler(this.Ordenarbutton_Click);
            // 
            // SalidarichTextBox
            // 
            this.SalidarichTextBox.Location = new System.Drawing.Point(16, 116);
            this.SalidarichTextBox.Name = "SalidarichTextBox";
            this.SalidarichTextBox.ReadOnly = true;
            this.SalidarichTextBox.Size = new System.Drawing.Size(83, 133);
            this.SalidarichTextBox.TabIndex = 3;
            this.SalidarichTextBox.Text = "";
            // 
            // Ordenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 261);
            this.Controls.Add(this.SalidarichTextBox);
            this.Controls.Add(this.Ordenarbutton);
            this.Controls.Add(this.CadenastextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ordenar";
            this.ShowIcon = false;
            this.Text = "Ordenar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CadenastextBox;
        private System.Windows.Forms.Button Ordenarbutton;
        private System.Windows.Forms.RichTextBox SalidarichTextBox;
    }
}