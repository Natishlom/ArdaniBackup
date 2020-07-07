using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArdaniBackup
{
    class DataRow
    {

        private ComboBox cbo;
        private TextBox txtSource, txtTarget, txtDateWork, txtTiminig;
        private Button btnSource, btnTarget, btnTurn;


        public DataRow()
        {
            cbo = new ComboBox
            {

            };
            txtSource = new TextBox { };
            txtTarget = new TextBox { };
            txtDateWork = new TextBox { };
            txtTiminig = new TextBox { };
            btnSource = new Button { };
            btnTarget = new Button { };
            btnTurn = new Button { };
        }

    }
}
