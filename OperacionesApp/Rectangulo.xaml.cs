namespace OperacionesApp;

public partial class Rectangulo : ContentPage
{
    private static object anchoRectangulo;
    private static object alturaRectangulo;
    private static object resultadoRectanguloLabel;

    public Rectangulo()
	{
        InitializeComponent();
	}

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void CalcularAreaRectangulo(object sender, EventArgs e)
    {
        if (double.TryParse(anchoRectangulo.Text, out double width) &&
            double.TryParse(alturaRectangulo.Text, out double height))
        {
            double area = width * height;
            resultadoRectanguloLabel.Text = $"Área: {area}";
        }
        else
        {
            DisplayAlert("Error", "Ingrese valores válidos", "OK");
        }
    }

    private static void limpiarRectangulo(object sender, EventArgs e)
    {
        anchoRectangulo.Text = string.Empty;
        alturaRectangulo.Text = string.Empty;
        resultadoRectanguloLabel.Text = string.Empty;
    }
}
