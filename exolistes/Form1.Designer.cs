namespace exolistes
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
            cboVerbe = new ComboBox();
            lblVerbe = new Label();
            grpChoix = new GroupBox();
            rdbItalien = new RadioButton();
            rdbEspagnol = new RadioButton();
            rdbAnglais = new RadioButton();
            rdbAllemand = new RadioButton();
            btnNouveau = new Button();
            grpResultat = new GroupBox();
            lblResultat = new Label();
            grpChoix.SuspendLayout();
            grpResultat.SuspendLayout();
            SuspendLayout();
            // 
            // cboVerbe
            // 
            cboVerbe.FormattingEnabled = true;
            cboVerbe.Location = new Point(447, 96);
            cboVerbe.Name = "cboVerbe";
            cboVerbe.Size = new Size(242, 40);
            cboVerbe.TabIndex = 0;
            cboVerbe.SelectedIndexChanged += cboVerbe_SelectedIndexChanged;
            // 
            // lblVerbe
            // 
            lblVerbe.AutoSize = true;
            lblVerbe.Location = new Point(252, 99);
            lblVerbe.Name = "lblVerbe";
            lblVerbe.Size = new Size(176, 32);
            lblVerbe.TabIndex = 1;
            lblVerbe.Text = "Choix du verbe";
            // 
            // grpChoix
            // 
            grpChoix.Controls.Add(rdbItalien);
            grpChoix.Controls.Add(rdbEspagnol);
            grpChoix.Controls.Add(rdbAnglais);
            grpChoix.Controls.Add(rdbAllemand);
            grpChoix.Location = new Point(252, 286);
            grpChoix.Name = "grpChoix";
            grpChoix.Size = new Size(400, 258);
            grpChoix.TabIndex = 2;
            grpChoix.TabStop = false;
            grpChoix.Tag = "1";
            grpChoix.Text = "Choix de la langue";
            grpChoix.Enter += grpChoix_Enter;
            // 
            // rdbItalien
            // 
            rdbItalien.AutoSize = true;
            rdbItalien.Location = new Point(24, 203);
            rdbItalien.Name = "rdbItalien";
            rdbItalien.Size = new Size(110, 36);
            rdbItalien.TabIndex = 3;
            rdbItalien.TabStop = true;
            rdbItalien.Tag = "4";
            rdbItalien.Text = "Italien";
            rdbItalien.UseVisualStyleBackColor = true;
            rdbItalien.CheckedChanged += rdbItalien_CheckedChanged;
            rdbItalien.Click += rdbAnglais_Click;
            // 
            // rdbEspagnol
            // 
            rdbEspagnol.AutoSize = true;
            rdbEspagnol.Location = new Point(24, 153);
            rdbEspagnol.Name = "rdbEspagnol";
            rdbEspagnol.Size = new Size(141, 36);
            rdbEspagnol.TabIndex = 2;
            rdbEspagnol.TabStop = true;
            rdbEspagnol.Tag = "3";
            rdbEspagnol.Text = "Espagnol";
            rdbEspagnol.UseVisualStyleBackColor = true;
            rdbEspagnol.CheckedChanged += rdbEspagnol_CheckedChanged;
            rdbEspagnol.Click += rdbAnglais_Click;
            // 
            // rdbAnglais
            // 
            rdbAnglais.AutoSize = true;
            rdbAnglais.Location = new Point(24, 52);
            rdbAnglais.Name = "rdbAnglais";
            rdbAnglais.Size = new Size(122, 36);
            rdbAnglais.TabIndex = 1;
            rdbAnglais.TabStop = true;
            rdbAnglais.Tag = "1";
            rdbAnglais.Text = "Anglais";
            rdbAnglais.UseVisualStyleBackColor = true;
            rdbAnglais.CheckedChanged += rdbAnglais_CheckedChanged;
            rdbAnglais.Click += rdbAnglais_Click;
            // 
            // rdbAllemand
            // 
            rdbAllemand.AutoSize = true;
            rdbAllemand.Location = new Point(24, 103);
            rdbAllemand.Name = "rdbAllemand";
            rdbAllemand.Size = new Size(146, 36);
            rdbAllemand.TabIndex = 0;
            rdbAllemand.TabStop = true;
            rdbAllemand.Tag = "2";
            rdbAllemand.Text = "Allemand";
            rdbAllemand.UseVisualStyleBackColor = true;
            rdbAllemand.CheckedChanged += rdbAllemand_CheckedChanged;
            rdbAllemand.Click += rdbAnglais_Click;
            // 
            // btnNouveau
            // 
            btnNouveau.Location = new Point(772, 92);
            btnNouveau.Name = "btnNouveau";
            btnNouveau.Size = new Size(150, 46);
            btnNouveau.TabIndex = 3;
            btnNouveau.Text = "Nouveau";
            btnNouveau.UseVisualStyleBackColor = true;
            btnNouveau.Click += btnNouveau_Click;
            // 
            // grpResultat
            // 
            grpResultat.Controls.Add(lblResultat);
            grpResultat.Location = new Point(252, 640);
            grpResultat.Name = "grpResultat";
            grpResultat.Size = new Size(400, 200);
            grpResultat.TabIndex = 4;
            grpResultat.TabStop = false;
            grpResultat.Text = "Resultat";
            // 
            // lblResultat
            // 
            lblResultat.AutoSize = true;
            lblResultat.Location = new Point(36, 79);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(0, 32);
            lblResultat.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 852);
            Controls.Add(grpResultat);
            Controls.Add(btnNouveau);
            Controls.Add(grpChoix);
            Controls.Add(lblVerbe);
            Controls.Add(cboVerbe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpChoix.ResumeLayout(false);
            grpChoix.PerformLayout();
            grpResultat.ResumeLayout(false);
            grpResultat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboVerbe;
        private Label lblVerbe;
        private GroupBox grpChoix;
        private RadioButton rdbItalien;
        private RadioButton rdbEspagnol;
        private RadioButton rdbAnglais;
        private RadioButton rdbAllemand;
        private Button btnNouveau;
        private GroupBox grpResultat;
        private Label lblResultat;
    }
}