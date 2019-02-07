using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmSubsRenamer
{
    public class Impostazioni
    {
        public bool tipoRinominaFile;
        public bool schermataIniziale;

        public Impostazioni()
        {
            if(Properties.Settings.Default.schermataIniziale)
            {
                schermataIniziale = true;
            }
            else
            {
                schermataIniziale = false;
            }
            if(Properties.Settings.Default.tipoRinominaFile)
            {
                schermataIniziale = true;
            }
            else
            {
                schermataIniziale = false;
            }
        }
    }
}
