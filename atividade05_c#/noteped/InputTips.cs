using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade05_c_.noteped
{
    internal class InputTips
    {
        public static void Save (ObjectUser a, string NewContent)
        {
            a.Save(NewContent);
        }
        public static void NewName(ObjectUser a, string NewName)
        {
            a.ModificName(NewName);
        }
    }

}
