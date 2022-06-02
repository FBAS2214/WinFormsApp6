using System.Globalization;
using System.Net;
using System.Text;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // RegionInfo region = new RegionInfo("en-US");
            // MessageBox.Show(region.EnglishName);


            // WebClient wc = new WebClient();
            // var bytes = wc.DownloadData("https://en.wikipedia.org/wiki/Main_Page");
            // var str = Encoding.Default.GetString(bytes);
            // richTextBox1.Text = str;



            HttpClient client = new HttpClient();
            var str = client.GetStringAsync("https://en.wikipedia.org/wiki/Main_Page").Result;
            richTextBox1.Text = str;




            var items = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            List<string> list = new List<string>();

            foreach (CultureInfo cul in items)
            {
                RegionInfo country = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                list.Add(country.EnglishName);
            }




            comboBox1.Items.AddRange(list.Distinct().ToArray());
            comboBox1.Sorted = true;

            string countryName = "Azerbaijan";
            pictureBox1.LoadAsync($"https://countryflagsapi.com/png/{countryName}");
        }



        private void btn_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files|*.*|Text Files|*.txt";
            openFileDialog1.FilterIndex = 2;

            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // openFileDialog1.FileNames[]

                using StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
            }
        }



        private void btn_open_folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }




        private void btn_color_Click(object sender, EventArgs e)
        {
            // colorDialog1.FullOpen = false;
            // colorDialog1.ShowHelp = true;


            colorDialog1.ShowDialog();
            lbl_color.ForeColor = colorDialog1.Color;
        }





        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // if (e.Control && e.KeyCode == Keys.S)
            // {
            lbl_keycode.Text = e.KeyCode.ToString();
            //}
        }



        private void btn_font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            lbl_font.Font = fontDialog1.Font;
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string countryName = comboBox1.Text;
            pictureBox1.LoadAsync($"https://countryflagsapi.com/png/{countryName}");
        }
    }
}