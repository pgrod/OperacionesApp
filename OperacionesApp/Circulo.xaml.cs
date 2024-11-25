namespace OperacionesApp;

public partial class Circulo : ContentPage
{
    public Circulo()
    {
        InitializeComponent();
    }
    private void calcularAreaCirculo(object sender, EventArgs e)
    {
        if (double.TryParse(radioCirculo.Text, out double radius))
        {
            double area = Math.PI * radius * radius;
            resultadoCirculoLabel.Text = $"�rea: {area}";
        }
        else
        {
            DisplayAlert("Error", "Ingrese un valor v�lido", "OK");
        }
    }

    private void limpiarCirculo(object sender, EventArgs e)
    {
        radioCirculo.Text = string.Empty;
        resultadoCirculoLabel.Text = string.Empty;
    }
}