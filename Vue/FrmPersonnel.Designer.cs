
namespace AtelierPro1.Vue
{
    partial class frmPersonnel
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
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvListeDuPersonnel = new System.Windows.Forms.DataGridView();
            this.gpbAjouterUnSalarié = new System.Windows.Forms.GroupBox();
            this.btnAnnulerAj = new System.Windows.Forms.Button();
            this.btnEnregistrerAj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbListeDuPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDuPersonnel)).BeginInit();
            this.gpbAjouterUnSalarié.SuspendLayout();
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
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(353, 211);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(182, 39);
            this.btnAbsence.TabIndex = 3;
            this.btnAbsence.Text = "Gestion des absences";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.BtnAbsence_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(186, 212);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(147, 38);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(17, 211);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(148, 39);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // dgvListeDuPersonnel
            // 
            this.dgvListeDuPersonnel.AllowUserToAddRows = false;
            this.dgvListeDuPersonnel.AllowUserToDeleteRows = false;
            this.dgvListeDuPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDuPersonnel.Location = new System.Drawing.Point(17, 29);
            this.dgvListeDuPersonnel.MultiSelect = false;
            this.dgvListeDuPersonnel.Name = "dgvListeDuPersonnel";
            this.dgvListeDuPersonnel.ReadOnly = true;
            this.dgvListeDuPersonnel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListeDuPersonnel.Size = new System.Drawing.Size(715, 176);
            this.dgvListeDuPersonnel.TabIndex = 0;
            // 
            // gpbAjouterUnSalarié
            // 
            this.gpbAjouterUnSalarié.Controls.Add(this.btnAnnulerAj);
            this.gpbAjouterUnSalarié.Controls.Add(this.btnEnregistrerAj);
            this.gpbAjouterUnSalarié.Controls.Add(this.label5);
            this.gpbAjouterUnSalarié.Controls.Add(this.cboService);
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
            // btnAnnulerAj
            // 
            this.btnAnnulerAj.Location = new System.Drawing.Point(186, 166);
            this.btnAnnulerAj.Name = "btnAnnulerAj";
            this.btnAnnulerAj.Size = new System.Drawing.Size(147, 38);
            this.btnAnnulerAj.TabIndex = 11;
            this.btnAnnulerAj.Text = "Annuler";
            this.btnAnnulerAj.UseVisualStyleBackColor = true;
            this.btnAnnulerAj.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnEnregistrerAj
            // 
            this.btnEnregistrerAj.Location = new System.Drawing.Point(17, 166);
            this.btnEnregistrerAj.Name = "btnEnregistrerAj";
            this.btnEnregistrerAj.Size = new System.Drawing.Size(148, 38);
            this.btnEnregistrerAj.TabIndex = 10;
            this.btnEnregistrerAj.Text = "Enregistrer";
            this.btnEnregistrerAj.UseVisualStyleBackColor = true;
            this.btnEnregistrerAj.Click += new System.EventHandler(this.BtnEnregistrerAj_Click);
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
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(484, 127);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(247, 28);
            this.cboService.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(484, 82);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(248, 27);
            this.txtMail.TabIndex = 7;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(484, 36);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(248, 27);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(86, 82);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(225, 27);
            this.txtPrenom.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(87, 36);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(224, 27);
            this.txtNom.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "téléphone";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // frmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.gpbAjouterUnSalarié);
            this.Controls.Add(this.gpbListeDuPersonnel);
            this.Name = "frmPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonnel";
            this.gpbListeDuPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDuPersonnel)).EndInit();
            this.gpbAjouterUnSalarié.ResumeLayout(false);
            this.gpbAjouterUnSalarié.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}