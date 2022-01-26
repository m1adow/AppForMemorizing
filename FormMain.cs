using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace AppForMemorizing
{
    public partial class FormMain : Form
    {
        List<Translate> translates = new();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAddForm_Click(object sender, EventArgs e)
        {
            FormAdd form = new();
            form.Show();
            form.FormClosed += Form_FormClosed;    
        }

        private void buttonCheckForm_Click(object sender, EventArgs e)
        {
            FormCheck form = new();
            form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadMethod();
            RefreshMethod();
        }

        public void RefreshMethod(int button = 0)
        {
            textBoxSearch.Clear();
            listBox.Items.Clear();
            
            if (button == 0)           
                for (int i = 0; i < translates.Count; i++)
                    listBox.Items.Add($"{i + 1}. {translates[i]}");            
            else if (button == 1)
                listBox.Items.AddRange(translates.OrderBy(a => a.ForeignWord).ToArray());
            else if (button == 2)
                listBox.Items.AddRange(translates.OrderByDescending(a => a.ForeignWord).ToArray());
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

        public void SaveMethod()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Settings.Path, false, Encoding.Default))                
                    sw.WriteLine(JsonSerializer.Serialize(translates));               
            }
            catch { }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadMethod();
            RefreshMethod();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                translates.RemoveAt(listBox.SelectedIndex);
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
            catch { }

            RefreshMethod();
            SaveMethod();
        }

        private void buttonSortAZ_Click(object sender, EventArgs e)
        {
            RefreshMethod(1);
        }

        private void buttonZA_Click(object sender, EventArgs e)
        {
            RefreshMethod(2);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshMethod();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(translates.Where(a => a.ForeignWord.StartsWith(textBoxSearch.Text.ToUpper())).ToArray());
        }
    }
}