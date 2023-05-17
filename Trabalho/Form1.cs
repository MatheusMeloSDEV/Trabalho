using MongoDB.Driver;
//using CLUSA;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        public static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        public static IMongoDatabase db = client.GetDatabase("Trabalho");
        public static IMongoCollection<Navios> collection = db.GetCollection<Navios>("Navios");

        public Form1()
        {
            InitializeComponent();
            readData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Navios navios = new Navios(txtName.Text, txtAge.Text, txtMail.Text, txtDog.Text);
            collection.InsertOne(navios);
            readData();
        }

        public void readData()
        {
            List<Navios> list = collection.AsQueryable().ToList();
            dgvNavios.DataSource = list;

            txtName.Text = dgvNavios.Rows[0].Cells[1].Value.ToString();
            txtAge.Text = dgvNavios.Rows[0].Cells[2].Value.ToString();
            txtMail.Text = dgvNavios.Rows[0].Cells[3].Value.ToString();
            txtDog.Text = dgvNavios.Rows[0].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
    public class Navios
    {
        [BsonId]
        [BsonRepresentationAttribute(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("age")]
        public string Age { get; set; }

        [BsonElement("mail")]
        public string Mail { get; set; }

        [BsonElement("cachorro")]
        public string Cachorro { get; set; }

        public Navios(string name, string age, string mail, string cachorro)
        {
            Name = name;
            Age = age;
            Mail = mail;
            Cachorro = cachorro;
        }
    }
}