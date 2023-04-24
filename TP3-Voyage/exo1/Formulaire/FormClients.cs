using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO; 

namespace exo1.Formulaire
{
    //lVoyages = new List<Voyage>();
    [Serializable]
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();

        }
        private List<Client> lstClient = new List<Client>();

     
        private void sauvegarde()
            {
                FileStream stream = new FileStream("data",FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream,lstClient);

               stream.Close();

            }
        private void chargement()
        {
            if (File.Exists("data"))
            {

                BinaryFormatter deserializer = new BinaryFormatter();

                FileStream stream = new FileStream("data", FileMode.Open);

                lstClient = (List<Client>)deserializer.Deserialize(stream);

                stream.Close();

            }

        }

            private void FormClient_Load(object sender, System.EventArgs e)
            {
                chargement();
            }
            /*private void FormCient_FormClosing()
            { 
            sauvegarde();
            }*/
    }
}
