using P8_Administrador_de_tareas.MVVM.Modelo;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P8_Administrador_de_tareas.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    class TareasVM
    {

        private ObservableCollection<Categoria> listaCategorias;
        private ObservableCollection<Tarea> listaTareas;

        public ObservableCollection<Categoria> ListaCategorias { get { return this.listaCategorias; } set { this.listaCategorias = value; SetearTareasTotales(); } }
        public ObservableCollection<Tarea> ListaTareas { get { return this.listaTareas; } set { this.listaTareas = value; SetearTareasTotales(); } }


        public TareasVM()
        {
            this.listaCategorias= new ObservableCollection<Categoria>() { 
                new Categoria("Categoria 1"),
                new Categoria("Categoria 2")

            };

            this.listaTareas = new ObservableCollection<Tarea>()
            {
                new Tarea("Tarea1",1),
                new Tarea("Tarea2",2),
                new Tarea("Tarea1",1),
                new Tarea("Tarea2",2),
                new Tarea("Tarea1",1),
                new Tarea("Tarea2",2),
                new Tarea("Tarea1",1),
                new Tarea("Tarea2",2),
                new Tarea("Tarea1",1),
                new Tarea("Tarea2",2),
                new Tarea("Tarea1",1),
                new Tarea("Tarea2",2),

            };
            SetearTareasTotales();
            
            
        }

        public void SetearTareasTotales()
        {
            foreach (Categoria item in ListaCategorias)
            {
                int tareas = ListaTareas.Where(d => d.IdCategoria == item.ID).ToList().Count;
                item.TareasTotales = tareas;

                int tareasCompletadas = ListaTareas.Where(d => d.IdCategoria == item.ID && d.Completada==true).ToList().Count;
                item.TareasCompletadas = tareasCompletadas;
                Console.WriteLine();
            }
            
        }

      
    }
}
