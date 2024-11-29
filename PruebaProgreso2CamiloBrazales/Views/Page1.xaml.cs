namespace PruebaProgreso2CamiloBrazales.Views;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}
    private void Recarga(object sender, EventArgs e)
    {
        string path = FileSystem.AppDataDirectory;
        string filename = "vivalaliga.txt";
        string pathfile = path + filename;
        // This text is added only once to the file.
        if (!File.Exists(pathfile))
        {
            File.WriteAllText(pathfile,"" );
        }
        string appendText = Environment.NewLine;
        File.AppendAllText(path, appendText);

        // Open the file to read from.
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);
    }
}