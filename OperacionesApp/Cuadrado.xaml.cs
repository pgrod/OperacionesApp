namespace OperacionesApp;

public partial class Cuadrado : ContentPage
{
    public Cuadrado()
    {
        InitializeComponent();
    }

        private void calcularAreaCuadrado(object sender, EventArgs e)
        {
            if (double.TryParse(ladosCuadrado.Text, out double side))
            {
                double area = side * side;
                resultadoCuadradoLabel.Text = $"Área: {area}";
            }
            else
            {
                DisplayAlert("Error", "Ingrese un valor válido", "OK");
            }
        }

        private void LimpiarCuadrado(object sender, EventArgs e)
        {
            ladosCuadrado.Text = string.Empty;
            resultadoCuadradoLabel.Text = string.Empty;
        }
}