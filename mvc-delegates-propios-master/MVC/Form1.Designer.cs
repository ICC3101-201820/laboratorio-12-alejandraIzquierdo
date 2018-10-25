namespace MVC
{
    partial class Form1
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
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.proteinaTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.proteina = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grasa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ch = new System.Windows.Forms.Label();
            this.grasaTextBox = new System.Windows.Forms.TextBox();
            this.carbohidratoTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comidas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(107, 38);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(85, 20);
            this.nombreTextBox.TabIndex = 0;
            // 
            // proteinaTextBox
            // 
            this.proteinaTextBox.Location = new System.Drawing.Point(107, 82);
            this.proteinaTextBox.Name = "proteinaTextBox";
            this.proteinaTextBox.Size = new System.Drawing.Size(85, 20);
            this.proteinaTextBox.TabIndex = 1;
            this.proteinaTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(16, 41);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 2;
            this.nombreLabel.Text = "Nombre";
            this.nombreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // proteina
            // 
            this.proteina.AutoSize = true;
            this.proteina.Location = new System.Drawing.Point(12, 89);
            this.proteina.Name = "proteina";
            this.proteina.Size = new System.Drawing.Size(53, 13);
            this.proteina.TabIndex = 3;
            this.proteina.Text = "Proteínas";
            this.proteina.Click += new System.EventHandler(this.proteina_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(33, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grasa
            // 
            this.grasa.AutoSize = true;
            this.grasa.Location = new System.Drawing.Point(16, 135);
            this.grasa.Name = "grasa";
            this.grasa.Size = new System.Drawing.Size(40, 13);
            this.grasa.TabIndex = 6;
            this.grasa.Text = "Grasas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Listado";
            // 
            // ch
            // 
            this.ch.AutoSize = true;
            this.ch.Location = new System.Drawing.Point(12, 180);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(72, 13);
            this.ch.TabIndex = 8;
            this.ch.Text = "Carbohidratos";
            // 
            // grasaTextBox
            // 
            this.grasaTextBox.Location = new System.Drawing.Point(107, 128);
            this.grasaTextBox.Name = "grasaTextBox";
            this.grasaTextBox.Size = new System.Drawing.Size(85, 20);
            this.grasaTextBox.TabIndex = 9;
            // 
            // carbohidratoTextBox
            // 
            this.carbohidratoTextBox.Location = new System.Drawing.Point(107, 173);
            this.carbohidratoTextBox.Name = "carbohidratoTextBox";
            this.carbohidratoTextBox.Size = new System.Drawing.Size(85, 20);
            this.carbohidratoTextBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(89, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Eliminar Selección";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comidas);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(536, 346);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nombreLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.carbohidratoTextBox);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(this.ch);
            this.panel1.Controls.Add(this.proteina);
            this.panel1.Controls.Add(this.grasaTextBox);
            this.panel1.Controls.Add(this.proteinaTextBox);
            this.panel1.Controls.Add(this.grasa);
            this.panel1.Location = new System.Drawing.Point(17, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 250);
            this.panel1.TabIndex = 12;
            // 
            // comidas
            // 
            this.comidas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comidas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comidas.Location = new System.Drawing.Point(21, 63);
            this.comidas.Name = "comidas";
            this.comidas.Size = new System.Drawing.Size(253, 196);
            this.comidas.TabIndex = 12;
            this.comidas.TabStop = false;
            this.comidas.Text = "ListaComida";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox proteinaTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label proteina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label grasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ch;
        private System.Windows.Forms.TextBox grasaTextBox;
        private System.Windows.Forms.TextBox carbohidratoTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox comidas;
    }
}

