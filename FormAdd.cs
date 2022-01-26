using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;


namespace AppForMemorizing
{
    public partial class FormAdd : Form
    {
        List<Translate> translates = new();

        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxForeign.Text != null && textBoxNative.Text != null)
                AddMethod();           
        }

        public void ClearTextBoxes()
        {
            textBoxForeign.Clear();
            textBoxNative.Clear();
        }

        public void AddMethod()
        {
            LoadMethod();

            for (int i = 0; i < translates.Count; i++)
                if (textBoxForeign.Text.ToUpper() == translates[i].ForeignWord.ToUpper())
                    translates.RemoveAt(i);

            translates.Add(new(textBoxForeign.Text.ToUpper(), textBoxNative.Text.ToUpper()));
            SaveMethod();
            ClearTextBoxes();
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
