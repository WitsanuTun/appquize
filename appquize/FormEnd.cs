using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appquize
{
    public partial class FormEnd : Form
    {
        public FormEnd(int point)
        {
            InitializeComponent();
            Console.WriteLine(point.ToString());
            label2.Text = point.ToString();
        }
    }
}
