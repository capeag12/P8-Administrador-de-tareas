using P8_Administrador_de_tareas.MVVM.Modelo;
using P8_Administrador_de_tareas.MVVM.ViewModel;
using PropertyChanged;

namespace P8_Administrador_de_tareas.MVVM.View;
public partial class ViewTareas : ContentPage
{
	private TareasVM tareasVM;
	
	public ViewTareas()
	{
		InitializeComponent();
		this.tareasVM = new TareasVM();
		BindingContext= this.tareasVM;
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Console.WriteLine();
        BindingContext = this.tareasVM;
    }
}