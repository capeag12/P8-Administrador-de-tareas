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

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		tareasVM.SetearTareasTotales();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ViewAdd(tareasVM.ListaCategorias,tareasVM.ListaTareas));
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
		this.tareasVM.SetearTareasTotales();

    }
}