
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
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.gpbAjouterAbsences = new System.Windows.Forms.GroupBox();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.cbbMotif = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gpbAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.gpbAjouterAbsences.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAbsence
            // 
            this.gpbAbsence.Controls.Add(this.btnSupprimer);
            this.gpbAbsence.Controls.Add(this.dgvAbsence);
            this.gpbAbsence.Location = new System.Drawing.Point(29, 22);
            this.gpbAbsence.Name = "gpbAbsence";
            this.gpbAbsence.Size = new System.Drawing.Size(755, 307);
            this.gpbAbsence.TabIndex = 0;
            this.gpbAbsence.TabStop = false;
            this.gpbAbsence.Text = "Absences";
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(12, 29);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.RowHeadersWidth = 51;
            this.dgvAbsence.RowTemplate.Height = 29;
            this.dgvAbsence.Size = new System.Drawing.Size(722, 205);
            this.dgvAbsence.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 252);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(148, 38);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // gpbAjouterAbsences
            // 
            this.gpbAjouterAbsences.Controls.Add(this.btnAnnuler);
            this.gpbAjouterAbsences.Controls.Add(this.btnEnregistrer);
            this.gpbAjouterAbsences.Controls.Add(this.label3);
            this.gpbAjouterAbsences.Controls.Add(this.cbbMotif);
            this.gpbAjouterAbsences.Controls.Add(this.dtpDateFin);
            this.gpbAjouterAbsences.Controls.Add(this.label2);
            this.gpbAjouterAbsences.Controls.Add(this.label1);
            this.gpbAjouterAbsences.Controls.Add(this.dtpDateDebut);
            this.gpbAjouterAbsences.Location = new System.Drawing.Point(29, 344);
            this.gpbAjouterAbsences.Name = "gpbAjouterAbsences";
            this.gpbAjouterAbsences.Size = new System.Drawing.Size(754, 145);
            this.gpbAjouterAbsences.TabIndex = 1;
            this.gpbAjouterAbsences.TabStop = false;
            this.gpbAjouterAbsences.Text = "Ajouter une absence";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(104, 35);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(266, 27);
            this.dtpDateDebut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "date début";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "date fin";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(104, 79);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(266, 27);
            this.dtpDateFin.TabIndex = 3;
            // 
            // cbbMotif
            // 
            this.cbbMotif.FormattingEnabled = true;
            this.cbbMotif.Location = new System.Drawing.Point(469, 31);
            this.cbbMotif.Name = "cbbMotif";
            this.cbbMotif.Size = new System.Drawing.Size(265, 28);
            this.cbbMotif.TabIndex = 4;
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
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(418, 86);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(146, 38);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(588, 86);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(146, 38);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.gpbAjouterAbsences);
            this.Controls.Add(this.gpbAbsence);
            this.Name = "FrmAbsence";
            this.Text = "FrmAbsence";
            this.gpbAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.gpbAjouterAbsences.ResumeLayout(false);
            this.gpbAjouterAbsences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.GroupBox gpbAjouterAbsences;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMotif;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
    }
}