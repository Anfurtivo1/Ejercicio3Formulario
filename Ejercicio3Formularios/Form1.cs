using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cdlMenuColor.ShowDialog();
            this.BackColor= cdlMenuColor.Color;
        }

        private void btnTipoLetra_Click(object sender, EventArgs e)
        {
            fdlMenuFuente.ShowDialog();
            fdlMenuFuente.Font;
            fdlMenuFuente.ShowColor;
            fdlMenuFuente.ShowEffects;
            fdlMenuFuente.AllowScriptChange;
            fdlMenuFuente.Color;
        }
    }
}
