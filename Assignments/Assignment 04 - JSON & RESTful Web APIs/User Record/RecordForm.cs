using System;
using System.Drawing;
using System.Windows.Forms;
using RestSharp;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;

namespace User_Record
{
    public partial class RecordForm : Form
    {
        private readonly User[] users = RetrieveData().data;
        private static int counter = 0; 
        private static readonly int max = RetrieveData().total; //total users

        public RecordForm()
        {
            InitializeComponent();
        }

        private static Data RetrieveData()
        {
            Data data = null;
            //using restsharp
            try
            {
                var client = new RestClient("https://reqres.in/api/users?per_page=1000");
                var jsonString = client.Execute(new RestRequest());
                data = JsonConvert.DeserializeObject<Data>(jsonString.Content);

            }
            catch (Exception)
            {
                MessageBox.Show("Error getting JSON data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //using asyc from HttpClient
            //string jsonString = new HttpClient().GetStringAsync(new Uri("https://reqres.in/api/users?per_page=1000")).Result;
            //result = JsonConvert.DeserializeObject<Data>(jsonString);
            //return result

            //using webclient
            //var client = new WebClient();
            //string jsonString = client.DownloadString("https://reqres.in/api/users?per_page=1000");
            //result = JsonConvert.DeserializeObject<Data>(jsonString);
            return data;
        }
        private void SetImage(string url) //creating an image from url
        {
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
                pictureBox.Image = Bitmap.FromStream(stream);
        }

        private void FillUserBoxes(User user)
        {
            idTextBox.Text = (user.ID).ToString();
            firstNameTextBox.Text = (user.FirstName).ToString();
            lastNameTextBox.Text = (user.LastName).ToString();
            emailTextBox.Text = (user.Email).ToString();
            SetImage((user.Avatar).ToString());
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            User currentUser = users[0]; // starts with first user in data array
            FillUserBoxes(currentUser);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (counter <= 0)
                counter = max;

            try
            {
                User currentUser = users[--counter];
                FillUserBoxes(currentUser);
            }
            catch (Exception) //just in case something goes wrong with going back and forth
            {
                MessageBox.Show("No more records to show.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (counter >= max - 1)
                counter = -1;

            try
            {
                User currentUser = users[++counter];
                FillUserBoxes(currentUser);
            }
            catch (Exception)
            {
                MessageBox.Show("No more records to show.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}