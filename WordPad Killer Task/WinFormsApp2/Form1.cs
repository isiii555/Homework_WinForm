using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var font in FontFamily.Families)
            {
                font_combo.Items.Add(font.Name);
            }

            List<string> font_size = new() { "8", "9", "10", "11", "12", "14", "16", "18", "20", "24", "30", "36", "48", "60", "72" };

            color_combo.DataSource = typeof(Color).GetProperties()
            .Where(x => x.PropertyType == typeof(Color))
            .Select(x => x.GetValue(null)).ToList();

            size_combo.Items.AddRange(font_size.ToArray());

        }

        private void font_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            text.Font = new Font(font_combo.SelectedItem.ToString() ?? text.Font.Name, text.Font.Size, text.Font.Style);
        }

        private void size_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font.Name, Convert.ToSingle(size_combo.SelectedItem), text.Font.Style);

        }

        private void bold_button_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font.Name,text.Font.Size,FontStyle.Bold);
        }

        private void under_button_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font.Name, text.Font.Size, FontStyle.Underline);

        }

        private void italic_button_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font.Name, text.Font.Size, FontStyle.Italic);

        }

        private void color_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            text.ForeColor = (Color)color_combo.SelectedItem;
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            text.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void center_button_Click(object sender, EventArgs e)
        {
            text.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            text.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = load_text.Text;          
            try
            {
                text.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            catch(Exception em)
            {
                MessageBox.Show("FILE NOT FOUND","SYSTEM",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File| *.txt";
            saveFileDialog1.FileName = save_text.Text;
            File.WriteAllText($"{saveFileDialog1.FileName}.txt", text.Text);
        }

        private void load_text_MouseDown(object sender, MouseEventArgs e)
        {
            load_text.Text = null;
            load_text.ForeColor = Color.Black;
        }

        private void save_text_MouseDown(object sender, MouseEventArgs e)
        {
            save_text.Text = null;
            save_text.ForeColor = Color.Black;
        }
    }
}