using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AtelierPro1.Controleur;


namespace AtelierPro1.Vue
{
    /// <summary>
    /// Fenêtre d'authentification (seuls les admin peuvent accéder à l'application)
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        private Controle controle;
        public FrmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Demande au controleur de controler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSeConnecter_Click(object sender, EventArgs e)
        {
            if (!txbIdentifiant.Text.Equals("") && !txbPwd.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(txbIdentifiant.Text, txbPwd.Text))
                {
                    MessageBox.Show("Authentification incorrecte", "Alerte");
                    txbIdentifiant.Text = "";
                    txbPwd.Text = "";
                    txbIdentifiant.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

    }
}
