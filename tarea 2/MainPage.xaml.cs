using System;
using Xamarin.Forms;

namespace FormularioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            var nombre = NombreEntry.Text;
            var telefono = TelefonoEntry.Text;
            var email = EmailEntry.Text;
            var ubicacion = UbicacionEntry.Text;
            var linkedIn = LinkedInEntry.Text;

            var idioma1 = Idioma1Entry.Text;
            var idioma2 = Idioma2Entry.Text;
            var idioma3 = Idioma3Entry.Text;

            var aptitud1 = Aptitud1Entry.Text;
            var aptitud2 = Aptitud2Entry.Text;
            var aptitud3 = Aptitud3Entry.Text;
            var aptitud4 = Aptitud4Entry.Text;
            var aptitud5 = Aptitud5Entry.Text;

            var habilidad1 = Habilidad1Entry.Text;
            var habilidad2 = Habilidad2Entry.Text;
            var habilidad3 = Habilidad3Entry.Text;
            var habilidad4 = Habilidad4Entry.Text;
            var habilidad5 = Habilidad5Entry.Text;

            var interes1 = Interes1Entry.Text;
            var interes2 = Interes2Entry.Text;
            var interes3 = Interes3Entry.Text;

            var perfil = PerfilEditor.Text;
            var experiencia = ExperienciaEditor.Text;
            var formacion = FormacionEditor.Text;

            // Lógica para generar el currículum vitae con los datos ingresados.
            DisplayAlert("Currículum Generado", "Se ha generado el currículum vitae con éxito.", "OK");
        }
    }
}
