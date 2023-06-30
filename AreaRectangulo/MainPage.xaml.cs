namespace AreaRectangulo;
///<Summary>
///<Createddate>23/06/2023</Createddate>
///<company>INDEL</company>
///<lastmodificationdate>23/06/2023</lastmodificationdate>
///<lastmodifierautor>Erika chávez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
    /// <summary>
    /// constructor de la clase
    /// </summary>
    public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Al dar clic en el boton se calculara el perimetro y la 
	/// superficie del rectangulo y mostrara el resultado en un entry.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(h.Text) || (!string.IsNullOrEmpty(b.Text)))
        {
            double alt, bas, superf, peri;

            alt = Convert.ToDouble(h.Text);
            bas = Convert.ToDouble(b.Text);

            peri = 2 * (bas + alt);

            superf = bas * alt;

            Perimetro.Text = peri.ToString();
            Superficie.Text = superf.ToString();
        }
        else
        {
            DisplayAlert("Error", "Ocurrio un error al introducir el dato", "Gracias!");
        }
    }
}

