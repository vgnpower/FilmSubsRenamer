using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace FilmSubsRenamer
{
    public partial class frmPrincipale : Form
    {
        //TODO aggiungere dei settings degli utenti che decidono quale estensione abilitare dei file e metterle nel filtro
        //TODO far scegliere all'utente quale schermata vedere per prima se il manual rename o l'altro
        //Impostazioni ObjImpostazioni = new Impostazioni();

        static String percorsoVideo, estensioneVideo, percorsoSub, estensioneSub;
        static string[] extSub = new string[18] {".srt",".sbv",".sub",".mpsub",".lrc", ".cap", ".smi", ".sami", ".rt", ".vtt", ".ttml", ".dfxp", ".scc", ".stl", ".tds", ".cin", ".asc", ".cap" };
        static string[] extVideo = new string[20] { ".3gp", ".asf", ".avi", ".divx", ".flv", ".swf", ".mpeg", ".mp4", ".mov", ".ogm", ".wmv", ".mkv", ".nbr", ".rm", ".vob", ".svi", ".dlx", ".mxf", ".sfd", ".webm" };

        public frmPrincipale()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.schermataIniziale)
            {
                tabControl1.SelectedTab = tabPageManualRename;
                comboBox1.SelectedIndex = 1;
            }
            else
            {
                tabControl1.SelectedTab = tabPageAutoRename;
                comboBox1.SelectedIndex = 0;
            }
        }

        private void listBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            if (lstBoxAutoRename_RiordinaTuttiFiles.Items.Count != 0)
            {
                lstBoxAutoRename_RiordinaTuttiFiles.Items.Clear();
                toolStripStatusLabel1.ForeColor = Color.Yellow;
                toolStripStatusLabel1.Text = "In attesa...";
            }

            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            String[] listaVideo = new String[s.Length];
            String[] listaSubs = new String[s.Length];
            String estensione = "";
            String percorsoFiles = "";

            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    lstBoxAutoRename_RiordinaTuttiFiles.Items.Add(Path.GetFileName(s[i]));
                    percorsoFiles = Path.GetDirectoryName(s[i]);
                    estensione = Path.GetExtension(s[i]);

                    if (extVideo.Contains(estensione))
                    {
                        listaVideo[i] = Path.GetFileNameWithoutExtension(s[i]);
                    }
                    else
                    {
                        if(extSub.Contains(estensione))
                            listaSubs[i] = Path.GetFileNameWithoutExtension(s[i]);
                        else
                            MessageBox.Show("Errore, non è stato possibile identificare l'estensione del file: " + s[i]);
                    }
                }

                //Ordinamento per nome gli item degli array
                Array.Sort(listaSubs);
                Array.Sort(listaVideo);

                String[] temp = new String[s.Length];

                //Assegno a temp i valori di listaSubs e poi trovo la posizione in cui strovano gli item e li sposto nelle prime posizioni
                Array.Copy(listaSubs, temp, listaSubs.Length);
                Trova_e_Sposta(s.Length, ref temp);

                //Assegno all'array subs gli item ordinati di temp poi svuoto l'array temp
                Array.Copy(temp, listaSubs, listaSubs.Length);
                Array.Clear(temp, 0, temp.Length);

                //Assegno a temp i valori di listaVideo e poi trovo la posizione in cui strovano gli item e li sposto nelle prime posizioni
                Array.Copy(listaVideo, temp, listaVideo.Length);
                Trova_e_Sposta(s.Length, ref temp);

                //Assegno all'array video gli item ordinati di temp poi svuoto l'array temp
                Array.Copy(temp, listaVideo, listaVideo.Length);
                Array.Clear(temp, 0, temp.Length);

                //Cambia nome
                #region CambiaNomeAiFiles
                percorsoFiles = percorsoFiles + @"\";
                for (int i = 0; i < listaVideo.Length; i++)
                {
                    estensione = Path.GetExtension(s[i]);
                    if (extVideo.Contains(estensione) && (listaVideo[i] != null) && (listaSubs[i] != null))
                    {
                        File.Move(percorsoFiles + listaVideo[i] + estensione, percorsoFiles + listaSubs[i] + estensione);
                    }
                    else
                    {
                        if (extSub.Contains(estensione) && (listaSubs[i] != null) && (listaVideo[i] != null))
                        {
                            File.Move(percorsoFiles + listaSubs[i] + estensione, percorsoFiles + listaVideo[i] + estensione);
                        }
                        else
                        {
                            if ((listaSubs[i] != null) && (listaVideo[i] != null))
                                MessageBox.Show("Errore nel cambio nome dei file!");
                        }
                    }
                }
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = "Operazione completata!";
                #endregion
            }
            catch (Exception eccezione)
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Operazione non completata!";
                MessageBox.Show(eccezione.Message, "errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void Trova_e_Sposta(int lunghezza, ref String[] _temp)
        {
            #region oldTrova_e_Sposta
            //int j = 0; bool trovato = false;
            //for (i = 0; i < s.Length; i++ )
            //{
            //    if(!trovato)
            //    {
            //        if (temp[i] != null)
            //        {
            //            j = i;
            //            trovato = true;
            //        }
            //    }

            //}
            //for (i = 0; i < s.Length; i++)
            //{
            //    if (j < s.Length)
            //    {
            //        temp[i] = temp[j];
            //        temp[j] = null;
            //        j++;
            //    }
            //}
            #endregion
            int i = 0; bool trovato = false; int j = 0;
            //Trovo la posizione in cui si trovano
            do
            {
                if ((!trovato) && (_temp[i] != null))
                {
                    j = i;
                    trovato = true;
                }
                i++;
            } while ((i >= lunghezza) || (!trovato));

            //Sposto gli item nelle prime posizioni dell'array
            for (i = 0; i < lunghezza; i++)
            {
                if ((j < lunghezza) && (j != 0))
                {
                    _temp[i] = _temp[j];
                    _temp[j] = null;
                    j++;
                }
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        //ListboxManualRename subs
        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (lstBoxManualRename_FilesSubs.Items.Count != 0)
                lstBoxManualRename_FilesSubs.Items.Clear();

            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < s.Length; i++)
            {
                lstBoxManualRename_FilesSubs.Items.Add(Path.GetFileNameWithoutExtension(s[i]));
                percorsoSub = Path.GetDirectoryName(s[i]);
                estensioneSub = Path.GetExtension(s[i]);
            }
            //Ordinamento per nome
            String[] ordinaNome = new String[lstBoxManualRename_FilesSubs.Items.Count];

            for (int i = 0; i < lstBoxManualRename_FilesSubs.Items.Count; i++)
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
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                Properties.Settings.Default.schermataIniziale = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.schermataIniziale = true;
                Properties.Settings.Default.Save();
            }
        }

        //ListboxManualRenameVideo 
        //TODO da aggiornare l'aggiunta dei file negli array con s[i] invece di utilizzare la lista!
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            //Forse devo togliere l'if e lasciare il clear
            if (lstBoxManualRename_FileVideo.Items.Count != 0)
            {
                lstBoxManualRename_FileVideo.Items.Clear();
            }
            
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < s.Length; i++)
            {
                lstBoxManualRename_FileVideo.Items.Add(Path.GetFileNameWithoutExtension(s[i]));
                percorsoVideo = Path.GetDirectoryName(s[i]);
                estensioneVideo = Path.GetExtension(s[i]);
            }
            //Ordinamento per nome
            String[] ordinaNome = new String[lstBoxManualRename_FileVideo.Items.Count];

            for (int i = 0; i < lstBoxManualRename_FileVideo.Items.Count; i++)
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

                    File.Move(percorsoVideo + lstBoxManualRename_FileVideo.GetItemText(lstBoxManualRename_FileVideo.SelectedItem) + estensioneVideo, percorsoSub + lstBoxManualRename_FilesSubs.GetItemText(lstBoxManualRename_FilesSubs.SelectedItem) + estensioneVideo);
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