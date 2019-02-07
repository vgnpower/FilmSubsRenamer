using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilmSubsRenamer
{
    public partial class Form1 : Form
    {
        static String percorsoVideo;
        static String estensioneVideo;
        static String percorsoSub;
        static String estensioneSub;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO risolvere un bug per il quale se la selezione sono di file sparsi non li rinomina correttamente
        }
        private void listBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            if (lstBoxAutoRename_RiordinaTuttiFiles.Items.Count != 0)
            {
                lstBoxAutoRename_RiordinaTuttiFiles.Items.Clear();
            }

            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            String[] listaVideo = new String[s.Length];
            String[] listaSubs = new String[s.Length];
            String oldEstenzione = Path.GetExtension(s[0]);
            String estensione = "";
            String percorsoFiles = "";
            int i;

            try
            {
                for (i = 0; i < s.Length; i++)
                {
                    lstBoxAutoRename_RiordinaTuttiFiles.Items.Add(Path.GetFileNameWithoutExtension(s[i]));
                    percorsoFiles = Path.GetDirectoryName(s[i]);
                    estensione = Path.GetExtension(s[i]);
                    lstBoxAutoRename_RiordinaTuttiFiles.SelectedIndex = i;
                    //Inserisco nell'array in base all'estensione dei file
                    if (i == 1)
                    {
                        oldEstenzione = Path.GetExtension(s[i - 1]);
                    }
                    if (estensione == oldEstenzione)
                    {
                        listaVideo[i] = lstBoxAutoRename_RiordinaTuttiFiles.GetItemText(lstBoxAutoRename_RiordinaTuttiFiles.SelectedItem);
                    }
                    else
                    {
                        listaSubs[i] = lstBoxAutoRename_RiordinaTuttiFiles.GetItemText(lstBoxAutoRename_RiordinaTuttiFiles.SelectedItem);
                    }
                }

                //Ordinamento per nome
                #region OrdinaArrayPerNome
                String[] ordinaNome = new String[lstBoxAutoRename_RiordinaTuttiFiles.Items.Count];

                for (i = 0; i < lstBoxAutoRename_RiordinaTuttiFiles.Items.Count; i++)
                {
                    lstBoxAutoRename_RiordinaTuttiFiles.SelectedIndex = i;
                    ordinaNome[i] = lstBoxAutoRename_RiordinaTuttiFiles.GetItemText(lstBoxAutoRename_RiordinaTuttiFiles.SelectedItem);

                }

                Array.Sort(ordinaNome);
                lstBoxAutoRename_RiordinaTuttiFiles.Items.Clear();
                lstBoxAutoRename_RiordinaTuttiFiles.Items.AddRange(ordinaNome);
                #endregion

                String[] temp = new String[s.Length];

                //Assaegno a temp i valori di listaSuvs e poi trovo la posizione in cui strovano gli item e li sposto nelle prime posizioni
                Array.Copy(listaSubs, temp, listaSubs.Length);
                Trova_e_Sposta(s.Length, ref temp);

                //Assegno all'array subs gli item ordinati di temp poi svuoto l'array temp
                Array.Copy(temp, listaSubs, listaSubs.Length);
                Array.Clear(temp, 0, temp.Length);

                //Assaegno a temp i valori di listaVideo e poi trovo la posizione in cui strovano gli item e li sposto nelle prime posizioni
                Array.Copy(listaVideo, temp, listaVideo.Length);
                Trova_e_Sposta(s.Length, ref temp);

                //Assegno all'array video gli item ordinati di temp poi svuoto l'array temp
                Array.Copy(temp, listaVideo, listaVideo.Length);
                Array.Clear(temp, 0, temp.Length);

                //Cambia nome
                #region CambiaNomeAiFiles
                percorsoFiles = percorsoFiles + @"\";
                for (i = 0; i < s.Length; i++)
                {
                    if (i == 0)
                    {
                        estensione = Path.GetExtension(s[i]);
                    }
                    if ((listaVideo[i] != null) && (listaSubs[i] != null))
                    {
                        System.IO.File.Move(percorsoFiles + listaVideo[i] + estensione, percorsoFiles + listaSubs[i] + estensione);
                    }
                    toolStripStatusLabel1.ForeColor = Color.Green;
                    toolStripStatusLabel1.Text = "Operazione completata!";
                }
                #endregion
            }
            catch (Exception eccezione)
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Operazione non completata!";
                MessageBox.Show(eccezione.Message, "errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void Trova_e_Sposta(int lunghezza, ref String[]_temp)
        {
            #region oldTrova_e_Sposta
            ////int j = 0; bool trovato = false;
            ////for (i = 0; i < s.Length; i++ )
            ////{
            ////    if(!trovato)
            ////    {
            ////        if (temp[i] != null)
            ////        {
            ////            j = i;
            ////            trovato = true;
            ////        }
            ////    }

            ////}
            ////for (i = 0; i < s.Length; i++)
            ////{
            ////    if (j < s.Length)
            ////    {
            ////        temp[i] = temp[j];
            ////        temp[j] = null;
            ////        j++;
            ////    }
            ////}
            #endregion
            int i = 0; bool trovato = false; int j = 0;
            //Trovo la posizione in cui si trovano
            for (i = 0; i < lunghezza; i++)
            {
                if (!trovato)
                {
                    if (_temp[i] != null)
                    {
                        j = i;
                        trovato = true;
                    }
                }
                else
                {
                    break;
                }
            }
            //TODO per risolvere il bug che j=0 e poi ci sono n null e poi continuano dovrei fare un'array e incremnetare la j fino a quando non arrivo ad un valore != da null
            //Sposto gli item nelle prime posizioni dell'array
            for (i = 0; i < lunghezza; i++)
            {
                if (j != 0)
                {
                    if (j < lunghezza)
                    {
                        _temp[i] = _temp[j];
                        _temp[j] = null;
                        j++;
                    }
                }
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (lstBoxManualRename_FilesSubs.Items.Count != 0)
            {
                lstBoxManualRename_FilesSubs.Items.Clear();
            }
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;

            for (i = 0; i < s.Length; i++)
            {
                lstBoxManualRename_FilesSubs.Items.Add(Path.GetFileNameWithoutExtension(s[i]));
                percorsoSub = Path.GetDirectoryName(s[i]);
                estensioneSub = Path.GetExtension(s[i]);
            }
            //Ordinamento per nome
            String[] ordinaNome = new String[lstBoxManualRename_FilesSubs.Items.Count];

            for (i = 0; i < lstBoxManualRename_FilesSubs.Items.Count; i++)
            {
                lstBoxManualRename_FilesSubs.SelectedIndex = i;
                ordinaNome[i] = lstBoxManualRename_FilesSubs.GetItemText(lstBoxManualRename_FilesSubs.SelectedItem);
            }

            Array.Sort(ordinaNome);
            lstBoxManualRename_FilesSubs.Items.Clear();
            lstBoxManualRename_FilesSubs.Items.AddRange(ordinaNome);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (lstBoxManualRename_FileVideo.Items.Count != 0)
            {
                lstBoxManualRename_FileVideo.Items.Clear();
            }
            
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;

            for (i = 0; i < s.Length; i++)
            {
                lstBoxManualRename_FileVideo.Items.Add(Path.GetFileNameWithoutExtension(s[i]));
                percorsoVideo = Path.GetDirectoryName(s[i]);
                estensioneVideo = Path.GetExtension(s[i]);
            }
            //Ordinamento per nome
            String[] ordinaNome = new String[lstBoxManualRename_FileVideo.Items.Count];

            for (i = 0; i < lstBoxManualRename_FileVideo.Items.Count; i++)
            {
                lstBoxManualRename_FileVideo.SelectedIndex = i;
                ordinaNome[i] = lstBoxManualRename_FileVideo.GetItemText(lstBoxManualRename_FileVideo.SelectedItem);
            }

            Array.Sort(ordinaNome);
            lstBoxManualRename_FileVideo.Items.Clear();
            lstBoxManualRename_FileVideo.Items.AddRange(ordinaNome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            percorsoVideo = percorsoVideo + @"\";
            percorsoSub = percorsoSub + @"\";          
            try
            {
                for (int i = 0; i < lstBoxManualRename_FileVideo.Items.Count; i++)
                {
                    lstBoxManualRename_FileVideo.SelectedIndex = i;
                    lstBoxManualRename_FilesSubs.SelectedIndex = i;

                    System.IO.File.Move(percorsoVideo + lstBoxManualRename_FileVideo.GetItemText(lstBoxManualRename_FileVideo.SelectedItem) + estensioneVideo, percorsoSub + lstBoxManualRename_FilesSubs.GetItemText(lstBoxManualRename_FilesSubs.SelectedItem) + estensioneVideo);
                }
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Operazione completata!";
            }
            catch(Exception eccezione)
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Operazione non completata!";
                MessageBox.Show(eccezione.Message, "errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void lstBoxAutoRename_RiordinaTuttiFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
