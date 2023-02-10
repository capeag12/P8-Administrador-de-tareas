using P8_Administrador_de_tareas.MVVM.Modelo;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P8_Administrador_de_tareas.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class AddVM
    {
        public ObservableCollection<Categoria> ListaCategorias { get; set; }
        public ObservableCollection<Tarea> ListaTareas { get; set; }

        public int IdSel { get; set; }

        public string NombreNuevaTarea { get; set; }

        public ICommand AddTareasCommand { get; set; }

        public ICommand AddCategoriaCommand { get; set; }

        public AddVM(ObservableCollection<Categoria> listaCategorias, ObservableCollection<Tarea> listaTareas)
        {
            
            ListaCategorias = listaCategorias;
            ListaTareas = listaTareas;
            this.AddTareasCommand = new Command(() => {
                var nombre = NombreNuevaTarea;
                var id = IdSel;
                this.ListaTareas.Add(new Tarea(nombre, id));
                this.NombreNuevaTarea = "";
            });

            this.AddCategoriaCommand = new Command(async () => {
                string resultado =await App.Current.MainPage.DisplayPromptAsync("Añadir categoria", "", "Aceptar", "Cancelar");
                listaCategorias.Add(new Categoria(resultado));
                Console.WriteLine();
            });
            
        }


    }
}
