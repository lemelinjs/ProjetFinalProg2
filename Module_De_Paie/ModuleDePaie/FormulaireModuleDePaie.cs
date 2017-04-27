using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuleDePaie;

namespace Formulaire_de_paie
{
    public partial class Form1 : Form
    {
        private TabPage[] pages;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Premières étapes au démarrage du formulaire
        /// </summary>
        /// <param name="sender">Le formulaire</param>
        /// <param name="e">Le chargement du formulaire</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            CreerIndexEtCacherPages();
            module_de_paie_entity ctx = new module_de_paie_entity();
            comboBoxNomEmploye.DataSource = ctx.employes.ToList();
            comboBoxNomEmploye.DisplayMember = "NomComplet";
            comboBoxNomEmploye.ValueMember = "id";
        }

        /// <summary>
        /// Gérer le changement de nom dans la combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxNomEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherPages();

            module_de_paie_entity ctx = new module_de_paie_entity();
            IQueryable<employes> query = from employe in ctx.employes where employe.id == 1 select employe;
            foreach (employes employe in query)
            {
                textBoxAnniversiare.Text = employe.date_naissance.ToString();
            }
        }


        /// <summary>
        /// Créer un index avec toutes les pages du formulaire et cacher les pages de l'index 1 et +
        /// </summary>
        private void CreerIndexEtCacherPages()
        {
            //Instancier un tableau de pages
            pages = new TabPage[tabControlPage.TabCount];

            //Parcourir chacun des éléments pour instancier chacun des objets et les cacher
            for (int i = pages.Length-1; i >= 1; i--)
            {
                pages[i] = new TabPage();
                pages[i] = tabControlPage.TabPages[i];
                tabControlPage.TabPages.Remove(pages[i]);
            }
        }
        /// <summary>
        /// Afficher les pages si elle sont cachées
        /// </summary>
        private void AfficherPages()
        {
            for (int i = 1; i < pages.Length; i++)
            {
                if (!tabControlPage.Contains(pages[i]))
                {
                    tabControlPage.TabPages.Add(pages[i]);
                }
            }
        }
    }
}
