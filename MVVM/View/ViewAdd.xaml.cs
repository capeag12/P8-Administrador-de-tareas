using P8_Administrador_de_tareas.MVVM.Modelo;
using P8_Administrador_de_tareas.MVVM.ViewModel;
using System.Collections.ObjectModel;

namespace P8_Administrador_de_tareas.MVVM.View;

public partial class ViewAdd : ContentPage
{
	AddVM a�adirVM;

    public ViewAdd(ObservableCollection<Categoria> listaCategorias, ObservableCollection<Tarea> listaTareas)
    {
        InitializeComponent();
        this.a�adirVM = new AddVM(listaCategorias,listaTareas);
        BindingContext = a�adirVM;
    }
}