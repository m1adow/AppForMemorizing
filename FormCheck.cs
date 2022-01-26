using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace AppForMemorizing
{
    public partial class FormCheck : Form
    {
        List<Translate> translates = new();
        Random random = new();

        public FormCheck()
        {
            InitializeComponent();
        }

        private void FormCheck_Load(object sender, EventArgs e)
        {
            LoadMethod();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (textBoxTranslate.Text.ToUpper() == labelNativeWord.Text.ToUpper())
            {
                MessageBox.Show("You're right!");
                textBoxTranslate.Clear();
                buttonStart_Click(null, null);
            }
            else
            {
                textBoxTranslate.Clear();
                MessageBox.Show("Try again!");
            }             
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int index = random.Next(0, translates.Count);
            labelForeignWord.Text = translates[index].ForeignWord;
            labelNativeWord.Text = translates[index].NativeWord;
        }

        public void LoadMethod()
        {
            translates.Clear();

            try
            {
                using (StreamReader sr = new StreamReader(Settings.Path, Encoding.Default))               
                    translates = JsonSerializer.Deserialize<List<Translate>>(sr.ReadToEnd());                
            }
            catch { }
        }
    }
}