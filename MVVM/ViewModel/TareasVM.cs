using P8_Administrador_de_tareas.MVVM.Modelo;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Administrador_de_tareas.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    class TareasVM
    {
        private ObservableCollection<Categoria> listaCategorias;
        private ObservableCollection<Tarea> tareas;

        public TareasVM()
        {
            this.listaCategorias= new ObservableCollection<Categoria>() {
                new Categoria("Categoria 1", new ObservableCollection<Tarea>() { new Tarea("Tarea 1")}) ,
                new Categoria("Categoria 2", new ObservableCollection<Tarea>() { new Tarea("Tarea 2")}) ,

            };
        }

        public ObservableCollection<Categoria> ListaCategorias { get { return listaCategorias; } set { } }
        public ObservableCollection<Tarea> ListaTareas { get {
                ObservableCollection<Tarea> listaTarea = new ObservableCollection<Tarea>();
                foreach (var cat in listaCategorias)
                {
                    foreach (var item in cat.ListaTareas)
                    {
                        listaTarea.Add(item);
                    }
                }

                return listaTarea; 
            } set { } }

    }
}
