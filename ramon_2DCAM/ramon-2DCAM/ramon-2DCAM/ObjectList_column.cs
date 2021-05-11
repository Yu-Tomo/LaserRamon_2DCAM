using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ramon_2DCAM
{
    class ObjectList_column
    {
        public ObjectList_column(ListView LV)
        {
            int Lsize = LV.Width - 4;

            string[] colum_name = new string[4] { "名前", "X座標", "Y座標", "倍率" };
            int[] colum_width = new int[4] { 100, 72, 72, Lsize - (100 + 72 * 2) };
            /*リストビューのカラムを設定する*/
            ColumnHeader[] columnHeaders = new ColumnHeader[4];

            for (int i = 0; i < 4; i++)
            {
                columnHeaders[i] = new ColumnHeader();
                columnHeaders[i].Text = colum_name[i];
                columnHeaders[i].TextAlign = HorizontalAlignment.Left;
                columnHeaders[i].Width = colum_width[i];


                LV.Columns.Add(columnHeaders[i]);
            }
            LV.View = View.Details;
        }
        public ListView SetLayout(ListView LV)
        {

            return LV;
        }
    }
}
