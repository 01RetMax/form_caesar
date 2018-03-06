using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form_caesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_ver_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_sch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 1; j++)
            {
                if (tb_ver.Text != "")
                {
                    Char[] chararray = tb_ver.Text.ToCharArray();
                    int[] asciicode = new int[tb_ver.Text.Length];
                    string ergebnis = "";

                    for (int i = 0; i < tb_ver.Text.Length; i++)
                    {
                        asciicode[i] = Convert.ToInt32(chararray[i]);
                    }

                    for (int i = 0; i < tb_ver.Text.Length; i++)
                    {
                        asciicode[i] -= Convert.ToInt32(tb_sch.Text);
                    }

                    for (int i = 0; i < tb_ver.Text.Length; i++)
                    {
                        chararray[i] = Convert.ToChar(asciicode[i]);
                    }

                    for (int i = 0; i < tb_ver.Text.Length; i++)
                    {
                        ergebnis = ergebnis + Convert.ToString(chararray[i]);
                    }

                    tb_ent.Text = ergebnis;

                    break;
                }

                if (tb_ent.Text != "")
                {
                    Char[] chararray = tb_ent.Text.ToCharArray();
                    int[] asciicode = new int[tb_ent.Text.Length];
                    string ergebnis = "";

                    for (int i = 0; i < tb_ent.Text.Length; i++)
                    {
                        asciicode[i] = Convert.ToInt32(chararray[i]);
                    }

                    for (int i = 0; i < tb_ent.Text.Length; i++)
                    {
                        asciicode[i] += Convert.ToInt32(tb_sch.Text);
                    }

                    for (int i = 0; i < tb_ent.Text.Length; i++)
                    {
                        chararray[i] = Convert.ToChar(asciicode[i]);
                    }

                    for (int i = 0; i < tb_ent.Text.Length; i++)
                    {
                        ergebnis = ergebnis + Convert.ToString(chararray[i]);
                    }

                    tb_ver.Text = ergebnis;

                    break;
                }
            }
        }
    }
}
