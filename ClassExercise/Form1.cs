using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ClassExercise;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        loadingpoint = new LoadingPoint();
        loadingpoint.Name = "";
        loadingpoint.Weight = 0;
        loadingpoint.Distance = 0;
        ReadJsonFile();
    }
    //public List<LoadingPoint> objekte {get;set;}

    private void textBox1_Leave(object sender, EventArgs e)
    {
        loadingpoint.Name = textBox1.Text;
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
        loadingpoint.Weight = Convert.ToDecimal(textBox2.Text);
    }

    private void textBox3_Leave(object sender, EventArgs e)
    {
        loadingpoint.Distance = Convert.ToDecimal(textBox3.Text);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Fügt Name Gewicht und Distanz der Klasse LoadingPoint hinzu
        LoadingPoint.AllPoints.Add(loadingpoint);
        AddItemsToListView();
        GenerateJsonFile();
    }

    private void GenerateJsonFile()
    {
        string json = JsonSerializer.Serialize(LoadingPoint.AllPoints, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    private void ReadJsonFile()
    {
        jsonInhalt = File.ReadAllText(filePath);
        var loadingPoints2 = JsonSerializer.Deserialize<List<LoadingPoint>>(jsonInhalt);
        foreach (var objekte in loadingPoints2)
        {
            ListViewItem item = new ListViewItem();
            item.Text = objekte.Name;
            item.SubItems.Add(objekte.Weight.ToString());
            item.SubItems.Add(objekte.Distance.ToString());
            listView1.Items.Add(item);
        }
    }

    private void AddItemsToListView()
    {
        ListViewItem item = new ListViewItem();
        item.Text = loadingpoint.Name;
        item.SubItems.Add(loadingpoint.Weight.ToString());
        item.SubItems.Add(loadingpoint.Distance.ToString());
        listView1.Items.Add(item);
    }

    private LoadingPoint loadingpoint;
    string jsonInhalt;
    string filePath = "C:\\Users\\MartinA\\Programme\\JsonFiles\\LoadingPoints.json";

    private void button2_Click(object sender, EventArgs e)
    {

    }
}
