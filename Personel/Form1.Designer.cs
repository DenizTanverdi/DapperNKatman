namespace Personel
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
            this.groupBxPer = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxMaas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxDep = new System.Windows.Forms.TextBox();
            this.groupBxPer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBxPer
            // 
            this.groupBxPer.Controls.Add(this.label7);
            this.groupBxPer.Controls.Add(this.txtBxDep);
            this.groupBxPer.Controls.Add(this.label6);
            this.groupBxPer.Controls.Add(this.txtBxCity);
            this.groupBxPer.Controls.Add(this.label5);
            this.groupBxPer.Controls.Add(this.txtBxMaas);
            this.groupBxPer.Controls.Add(this.label4);
            this.groupBxPer.Controls.Add(this.txtBxMail);
            this.groupBxPer.Controls.Add(this.label3);
            this.groupBxPer.Controls.Add(this.txtBxPhone);
            this.groupBxPer.Controls.Add(this.label2);
            this.groupBxPer.Controls.Add(this.txtBxSurname);
            this.groupBxPer.Controls.Add(this.label1);
            this.groupBxPer.Controls.Add(this.txtBxName);
            this.groupBxPer.Location = new System.Drawing.Point(175, 30);
            this.groupBxPer.Name = "groupBxPer";
            this.groupBxPer.Size = new System.Drawing.Size(471, 246);
            this.groupBxPer.TabIndex = 0;
            this.groupBxPer.TabStop = false;
            this.groupBxPer.Text = "Personel Ekle";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(102, 29);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 20);
            this.txtBxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad";
            // 
            // txtBxSurname
            // 
            this.txtBxSurname.Location = new System.Drawing.Point(102, 57);
            this.txtBxSurname.Name = "txtBxSurname";
            this.txtBxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtBxSurname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon";
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(102, 83);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(100, 20);
            this.txtBxPhone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // txtBxMail
            // 
            this.txtBxMail.Location = new System.Drawing.Point(102, 109);
            this.txtBxMail.Name = "txtBxMail";
            this.txtBxMail.Size = new System.Drawing.Size(100, 20);
            this.txtBxMail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Maas";
            // 
            // txtBxMaas
            // 
            this.txtBxMaas.Location = new System.Drawing.Point(102, 138);
            this.txtBxMaas.Name = "txtBxMaas";
            this.txtBxMaas.Size = new System.Drawing.Size(100, 20);
            this.txtBxMaas.TabIndex = 10;
            this.txtBxMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxMaas_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Şehir";
            // 
            // txtBxCity
            // 
            this.txtBxCity.Location = new System.Drawing.Point(102, 164);
            this.txtBxCity.Name = "txtBxCity";
            this.txtBxCity.Size = new System.Drawing.Size(100, 20);
            this.txtBxCity.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Departman";
            // 
            // txtBxDep
            // 
            this.txtBxDep.Location = new System.Drawing.Point(102, 190);
            this.txtBxDep.Name = "txtBxDep";
            this.txtBxDep.Size = new System.Drawing.Size(100, 20);
            this.txtBxDep.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBxPer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBxPer.ResumeLayout(false);
            this.groupBxPer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBxPer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxMaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Button btnSave;
    }
}

