
namespace AtelierPro1.Vue
{
    partial class FrmPersonnel
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
            this.gpbListeDuPersonnel = new System.Windows.Forms.GroupBox();
            this.dgvListeDuPersonnel = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.gpbAjouterUnSalarié = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnregistrerAj = new System.Windows.Forms.Button();
            this.btnAnnulerAj = new System.Windows.Forms.Button();
            this.gpbModifier = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbPrénom = new System.Windows.Forms.TextBox();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerMod = new System.Windows.Forms.Button();
            this.btnAnnulerMod = new System.Windows.Forms.Button();
            this.gpbListeDuPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDuPersonnel)).BeginInit();
            this.gpbAjouterUnSalarié.SuspendLayout();
            this.gpbModifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbListeDuPersonnel
            // 
            this.gpbListeDuPersonnel.Controls.Add(this.btnAbsence);
            this.gpbListeDuPersonnel.Controls.Add(this.btnSupprimer);
            this.gpbListeDuPersonnel.Controls.Add(this.btnModifier);
            this.gpbListeDuPersonnel.Controls.Add(this.dgvListeDuPersonnel);
            this.gpbListeDuPersonnel.Location = new System.Drawing.Point(28, 12);
            this.gpbListeDuPersonnel.Name = "gpbListeDuPersonnel";
            this.gpbListeDuPersonnel.Size = new System.Drawing.Size(753, 256);
            this.gpbListeDuPersonnel.TabIndex = 0;
            this.gpbListeDuPersonnel.TabStop = false;
            this.gpbListeDuPersonnel.Text = "Liste du personnel";
            // 
            // dgvListeDuPersonnel
            // 
            this.dgvListeDuPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDuPersonnel.Location = new System.Drawing.Point(17, 29);
            this.dgvListeDuPersonnel.Name = "dgvListeDuPersonnel";
            this.dgvListeDuPersonnel.RowHeadersWidth = 51;
            this.dgvListeDuPersonnel.RowTemplate.Height = 29;
            this.dgvListeDuPersonnel.Size = new System.Drawing.Size(715, 176);
            this.dgvListeDuPersonnel.TabIndex = 0;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(17, 211);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(148, 39);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(186, 212);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(147, 38);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(353, 211);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(182, 39);
            this.btnAbsence.TabIndex = 3;
            this.btnAbsence.Text = "Gestion des absences";
            this.btnAbsence.UseVisualStyleBackColor = true;
            // 
            // gpbAjouterUnSalarié
            // 
            this.gpbAjouterUnSalarié.Controls.Add(this.btnAnnulerAj);
            this.gpbAjouterUnSalarié.Controls.Add(this.btnEnregistrerAj);
            this.gpbAjouterUnSalarié.Controls.Add(this.label5);
            this.gpbAjouterUnSalarié.Controls.Add(this.comboBox1);
            this.gpbAjouterUnSalarié.Controls.Add(this.txtMail);
            this.gpbAjouterUnSalarié.Controls.Add(this.txtTelephone);
            this.gpbAjouterUnSalarié.Controls.Add(this.txtPrenom);
            this.gpbAjouterUnSalarié.Controls.Add(this.txtNom);
            this.gpbAjouterUnSalarié.Controls.Add(this.label4);
            this.gpbAjouterUnSalarié.Controls.Add(this.label3);
            this.gpbAjouterUnSalarié.Controls.Add(this.label2);
            this.gpbAjouterUnSalarié.Controls.Add(this.label1);
            this.gpbAjouterUnSalarié.Location = new System.Drawing.Point(28, 284);
            this.gpbAjouterUnSalarié.Name = "gpbAjouterUnSalarié";
            this.gpbAjouterUnSalarié.Size = new System.Drawing.Size(752, 216);
            this.gpbAjouterUnSalarié.TabIndex = 1;
            this.gpbAjouterUnSalarié.TabStop = false;
            this.gpbAjouterUnSalarié.Text = "Ajouter un salarié";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "mail";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(87, 36);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(224, 27);
            this.txtNom.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(86, 82);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(225, 27);
            this.txtPrenom.TabIndex = 5;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(484, 36);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(248, 27);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(484, 82);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(248, 27);
            this.txtMail.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(484, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "service";
            // 
            // btnEnregistrerAj
            // 
            this.btnEnregistrerAj.Location = new System.Drawing.Point(17, 166);
            this.btnEnregistrerAj.Name = "btnEnregistrerAj";
            this.btnEnregistrerAj.Size = new System.Drawing.Size(148, 38);
            this.btnEnregistrerAj.TabIndex = 10;
            this.btnEnregistrerAj.Text = "Enregistrer";
            this.btnEnregistrerAj.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerAj
            // 
            this.btnAnnulerAj.Location = new System.Drawing.Point(186, 166);
            this.btnAnnulerAj.Name = "btnAnnulerAj";
            this.btnAnnulerAj.Size = new System.Drawing.Size(147, 38);
            this.btnAnnulerAj.TabIndex = 11;
            this.btnAnnulerAj.Text = "Annuler";
            this.btnAnnulerAj.UseVisualStyleBackColor = true;
            // 
            // gpbModifier
            // 
            this.gpbModifier.Controls.Add(this.btnAnnulerMod);
            this.gpbModifier.Controls.Add(this.btnEnregistrerMod);
            this.gpbModifier.Controls.Add(this.cbbService);
            this.gpbModifier.Controls.Add(this.txbMail);
            this.gpbModifier.Controls.Add(this.txbTelephone);
            this.gpbModifier.Controls.Add(this.txbPrénom);
            this.gpbModifier.Controls.Add(this.txbNom);
            this.gpbModifier.Controls.Add(this.label10);
            this.gpbModifier.Controls.Add(this.label9);
            this.gpbModifier.Controls.Add(this.label8);
            this.gpbModifier.Controls.Add(this.label7);
            this.gpbModifier.Controls.Add(this.label6);
            this.gpbModifier.Location = new System.Drawing.Point(28, 516);
            this.gpbModifier.Name = "gpbModifier";
            this.gpbModifier.Size = new System.Drawing.Size(751, 181);
            this.gpbModifier.TabIndex = 2;
            this.gpbModifier.TabStop = false;
            this.gpbModifier.Text = "Modifier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Prénom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "téléphone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "service";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(83, 31);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(223, 27);
            this.txbNom.TabIndex = 5;
            // 
            // txbPrénom
            // 
            this.txbPrénom.Location = new System.Drawing.Point(84, 75);
            this.txbPrénom.Name = "txbPrénom";
            this.txbPrénom.Size = new System.Drawing.Size(223, 27);
            this.txbPrénom.TabIndex = 6;
            // 
            // txbTelephone
            // 
            this.txbTelephone.Location = new System.Drawing.Point(480, 31);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(247, 27);
            this.txbTelephone.TabIndex = 7;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(479, 75);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(248, 27);
            this.txbMail.TabIndex = 8;
            // 
            // cbbService
            // 
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Location = new System.Drawing.Point(479, 124);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(248, 28);
            this.cbbService.TabIndex = 9;
            // 
            // btnEnregistrerMod
            // 
            this.btnEnregistrerMod.Location = new System.Drawing.Point(15, 141);
            this.btnEnregistrerMod.Name = "btnEnregistrerMod";
            this.btnEnregistrerMod.Size = new System.Drawing.Size(147, 34);
            this.btnEnregistrerMod.TabIndex = 10;
            this.btnEnregistrerMod.Text = "Enregistrer";
            this.btnEnregistrerMod.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerMod
            // 
            this.btnAnnulerMod.Location = new System.Drawing.Point(182, 142);
            this.btnAnnulerMod.Name = "btnAnnulerMod";
            this.btnAnnulerMod.Size = new System.Drawing.Size(146, 32);
            this.btnAnnulerMod.TabIndex = 11;
            this.btnAnnulerMod.Text = "Annuler";
            this.btnAnnulerMod.UseVisualStyleBackColor = true;
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.gpbModifier);
            this.Controls.Add(this.gpbAjouterUnSalarié);
            this.Controls.Add(this.gpbListeDuPersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "FrmPersonnel";
            this.gpbListeDuPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDuPersonnel)).EndInit();
            this.gpbAjouterUnSalarié.ResumeLayout(false);
            this.gpbAjouterUnSalarié.PerformLayout();
            this.gpbModifier.ResumeLayout(false);
            this.gpbModifier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbListeDuPersonnel;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvListeDuPersonnel;
        private System.Windows.Forms.GroupBox gpbAjouterUnSalarié;
        private System.Windows.Forms.Button btnAnnulerAj;
        private System.Windows.Forms.Button btnEnregistrerAj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbModifier;
        private System.Windows.Forms.Button btnEnregistrerMod;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.TextBox txbPrénom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnnulerMod;
    }
}