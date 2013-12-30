using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Conver : Form
    {
        private TextBox objTexBox = null;

        public Conver()
        {
            InitializeComponent();
        }

        private void Conver_Load(object sender, EventArgs e)
        {

        }

        private void ctGradosC_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTexBox = (TextBox)sender;
        }

        private void ctGradosF_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTexBox = (TextBox)sender;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
             try
      {
        double grados;
        // Si se escribió en la caja de texto grados centígrados...
        if (objTexBox == ctGradosC)
        {
          grados = Convert.ToDouble(ctGradosC.Text) * 9.0 / 5.0 + 32.0;
          // Mostrar el resultado redondeado a dos decimales
          ctGradosF.Text = string.Format("{0:F2}", grados);
        }
        // Si se escribió en la caja de texto grados Fahrenheit...
        if (objTexBox == ctGradosF)
        {
          grados = (Convert.ToDouble(ctGradosF.Text) - 32.0) * 5.0 / 9.0;
          // Mostrar el resultado redondeado a dos decimales
          ctGradosC.Text = string.Format("{0:F2}", grados);
        }
      }
      catch (FormatException)
      {
        ctGradosC.Text = "0,00";
        ctGradosF.Text = "32,00";
      }
    }
    

            
        }
    }

