using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ramon_2DCAM
{
    public partial class ramon_main : Form
    {
        public ramon_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*コンストラクタでコラムを作成*/
            ObjectList_column objectList_Cont = new ObjectList_column(objectList);
        }
    }
}
