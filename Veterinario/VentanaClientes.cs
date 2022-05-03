using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            
            InitializeComponent();
        }
       
        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        
        private void AñadirAnimal_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarMascota agregarmascota = new AgregarMascota();
            agregarmascota.Show();
        }
    }
}
