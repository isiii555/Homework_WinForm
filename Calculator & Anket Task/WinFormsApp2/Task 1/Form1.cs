using System.Text.Json;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string gender = male.Checked ? male.Text : female.Text;
            var person = new Person(name.Text, surname.Text, dadname.Text, country.Text, city.Text, number.Text, dateTimePicker1.Value, gender);
            var options = new JsonSerializerOptions { WriteIndented = true };
            var data = JsonSerializer.Serialize(person, options);
            File.WriteAllText($"{person.Name}.json", data);
            MessageBox.Show("Saved", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            Person p = new();
            try
            {
                var json = File.ReadAllText($"{search.Text}.json");
                p = JsonSerializer.Deserialize<Person>(json)!;
                name.Text = p.Name;
                surname.Text = p.Surname;
                country.Text = p.Country;
                dadname.Text = p.Dad;
                city.Text = p.City;
                number.Text = p.Number;
                dateTimePicker1.Value = p.Date;
                if (p.Gender == "Male")
                    male.Select();
                else if (p.Gender == "Female")
                    female.Select();
            }
            catch(Exception)
            {
                MessageBox.Show("Not found", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}