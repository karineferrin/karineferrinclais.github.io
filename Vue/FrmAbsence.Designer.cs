
using System;
using System.Windows.Forms;

namespace AtelierPro1.Vue
{
    partial class FrmAbsence
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
            this.gpbAbsence = new System.Windows.Forms.GroupBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnTerminer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.gpbAjouterAbsence = new System.Windows.Forms.GroupBox();
            this.txtIdpersonnel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.gpbAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.gpbAjouterAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAbsence
            // 
            this.gpbAbsence.Controls.Add(this.txtPrenom);
            this.gpbAbsence.Controls.Add(this.label5);
            this.gpbAbsence.Controls.Add(this.label4);
            this.gpbAbsence.Controls.Add(this.txtNom);
            this.gpbAbsence.Controls.Add(this.btnTerminer);
            this.gpbAbsence.Controls.Add(this.btnModifier);
            this.gpbAbsence.Controls.Add(this.btnSupprimer);
            this.gpbAbsence.Controls.Add(this.dgvAbsence);
            this.gpbAbsence.Location = new System.Drawing.Point(29, 22);
            this.gpbAbsence.Name = "gpbAbsence";
            this.gpbAbsence.Size = new System.Drawing.Size(755, 307);
            this.gpbAbsence.TabIndex = 1;
            this.gpbAbsence.TabStop = false;
            this.gpbAbsence.Text = "Absences";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(12, 143);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(185, 27);
            this.txtPrenom.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 66);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(185, 27);
            this.txtNom.TabIndex = 5;
            // 
            // btnTerminer
            // 
            this.btnTerminer.Location = new System.Drawing.Point(370, 251);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.Size = new System.Drawing.Size(148, 37);
            this.btnTerminer.TabIndex = 4;
            this.btnTerminer.Text = "Terminer";
            this.btnTerminer.UseVisualStyleBackColor = true;
            this.btnTerminer.Click += new System.EventHandler(this.BtnTerminer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 251);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(148, 37);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(193, 250);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(148, 38);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.AllowUserToAddRows = false;
            this.dgvAbsence.AllowUserToDeleteRows = false;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(217, 29);
            this.dgvAbsence.MultiSelect = false;
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            this.dgvAbsence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAbsence.Size = new System.Drawing.Size(517, 205);
            this.dgvAbsence.TabIndex = 0;
            // 
            // gpbAjouterAbsence
            // 
            this.gpbAjouterAbsence.Controls.Add(this.txtIdpersonnel);
            this.gpbAjouterAbsence.Controls.Add(this.label6);
            this.gpbAjouterAbsence.Controls.Add(this.btnAnnuler);
            this.gpbAjouterAbsence.Controls.Add(this.btnEnregistrer);
            this.gpbAjouterAbsence.Controls.Add(this.label3);
            this.gpbAjouterAbsence.Controls.Add(this.cboMotif);
            this.gpbAjouterAbsence.Controls.Add(this.dtpDateFin);
            this.gpbAjouterAbsence.Controls.Add(this.label2);
            this.gpbAjouterAbsence.Controls.Add(this.label1);
            this.gpbAjouterAbsence.Controls.Add(this.dtpDateDebut);
            this.gpbAjouterAbsence.Location = new System.Drawing.Point(29, 344);
            this.gpbAjouterAbsence.Name = "gpbAjouterAbsence";
            this.gpbAjouterAbsence.Size = new System.Drawing.Size(754, 162);
            this.gpbAjouterAbsence.TabIndex = 1;
            this.gpbAjouterAbsence.TabStop = false;
            this.gpbAjouterAbsence.Text = "Ajouter une absence";
            // 
            // txtIdpersonnel
            // 
            this.txtIdpersonnel.Location = new System.Drawing.Point(122, 31);
            this.txtIdpersonnel.Name = "txtIdpersonnel";
            this.txtIdpersonnel.Size = new System.Drawing.Size(266, 27);
            this.txtIdpersonnel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "idpersonnel";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(588, 86);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(146, 38);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(418, 86);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(146, 38);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "motif";
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(469, 31);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(265, 28);
            this.cboMotif.TabIndex = 4;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.CustomFormat = "dddd d MMMM yyyy";
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFin.Location = new System.Drawing.Point(122, 114);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(266, 27);
            this.dtpDateFin.TabIndex = 3;
            this.dtpDateFin.Value = new System.DateTime(2022, 6, 7, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "date fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "date début";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.CustomFormat = "dddd d MMMM yyyy";
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDebut.Location = new System.Drawing.Point(122, 72);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(266, 27);
            this.dtpDateDebut.TabIndex = 0;
            this.dtpDateDebut.Value = new System.DateTime(2022, 6, 7, 0, 0, 0, 0);
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.gpbAjouterAbsence);
            this.Controls.Add(this.gpbAbsence);
            this.Name = "FrmAbsence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbsence";
            this.gpbAbsence.ResumeLayout(false);
            this.gpbAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.gpbAjouterAbsence.ResumeLayout(false);
            this.gpbAjouterAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.GroupBox gpbAjouterAbsence;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Button btnModifier;
        private TextBox txtPrenom;
        private Label label5;
        private Label label4;
        private TextBox txtNom;
        private Button btnTerminer;
        private Label label6;
        private TextBox txtIdpersonnel;
    }
}