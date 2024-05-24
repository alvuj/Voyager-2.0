using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyager
{
    public partial class score : Form
    {
        public score()
        {
            InitializeComponent();
        }


        //staro
       /* private void Updatebutton_Click(object sender, EventArgs e)
        {
            string FilePath = @"path";
            string[] lines = File.ReadAllLines(FilePath);
            List<int> lista = new List<int>();
            foreach (string s in lines)
            {
                lista.Add(Convert.ToInt32(s));
                listReadFile.Items.Add(s);
            }
            //sortiranje
            lista.Sort();
            foreach (int x in lista)
            {
                listSortFile.Items.Add(x);
            }
        }*/

        //novo
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\AV\Desktop\rez\rez.txt";
            string[] lines = File.ReadAllLines(FilePath);
            List<int> lista = new List<int>();
            foreach (string s in lines)
            {
                if (int.TryParse(s.Trim(), out int score))
                {
                    lista.Add(score);
                    listReadFile.Items.Add(score.ToString());
                }
                else
                {
                    // Možete ovdje dodati logiku za rukovanje greškama
                    Console.WriteLine($"Neispravan unos koji nije moguće pretvoriti u broj: '{s}'");
                }
            }
            // Sortiranje
            lista.Sort();
            foreach (int x in lista)
            {
                listSortFile.Items.Add(x.ToString());
            }
        }

        private void Up2_Click(object sender, EventArgs e)
        {
            // string FilePath1 = @"path";
            string FilePath1 = @"C:\Users\AV\Desktop\rez\txt_ime.txt";
            string[] imena = File.ReadAllLines(FilePath1);
            List<int> nam = new List<int>();
            foreach (string s in imena)
            {

                listImena.Items.Add(s);
            }
        }

        private void listReadFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listImena_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listSortFIle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void score_Load(object sender, EventArgs e)
        {

        }
        bool uvjet = false;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string target = textBoxSearch.Text;
            string FilePath = @"C:\Users\AV\Desktop\rez\txt_ime.txt";
           // string FilePath = @"path";
            string[] lines = File.ReadAllLines(FilePath);
            List<int> lista = new List<int>();
            foreach (string s in lines)
            {
                lista.Add(Convert.ToInt32(s));
                listReadFile.Items.Add(s);
            }
            //sortiranje
            lista.Sort();
            foreach (int x in lista)
            {
                listSortFile.Items.Add(x);
            }
            
            
            foreach (string s in lines)
            {   
                if(s.Contains(target) == true)
                {
                    uvjet = true;
                    lista.Add(Convert.ToInt32(s));

                    listBoxSearch.Items.Add(s);
                    break;
                }
                else
                {
                    uvjet = false;
                }
                if (uvjet == true)
                {
                    
                }

            }
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length > 0)
            {
                string target = textBoxSearch.Text;
                string FilePath = @"path";
                string[] lines = File.ReadAllLines(FilePath);
                List<int> lista = new List<int>();
                foreach (string s in lines)
                {
                    if (s.Contains(target) == true)
                    {
                        uvjet = true;
                        lista.Add(Convert.ToInt32(s));

                        listBoxSearch.Items.Add(s);
                        break;
                    }
                    else
                    {
                        uvjet = false;
                    }
                    if (uvjet == true)
                    {

                    }
                }
           

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //StartScreen window = new StartScreen();
            //window.Show();
            this.Close();
        }
    }
}
