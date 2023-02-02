﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Administrador_de_tareas.MVVM.Modelo
{
    [AddINotifyPropertyChangedInterface]
    class Categoria
    {
        private string nombreCategoria;
        private ObservableCollection<Tarea> listaTareas;

        public int TareasCompletadas { get { return listaTareas.Where(t => t.Completada == true).Count(); } set {this.TareasCompletadas = listaTareas.Where(t => t.Completada == true).Count(); } }

        public int TareasTotales { get { return this.listaTareas.Count; } set { this.TareasTotales = listaTareas.Count; } }

        public Categoria(string nombreCategoria, ObservableCollection<Tarea> listaTareas)
        {
            this.nombreCategoria = nombreCategoria;
            this.listaTareas = listaTareas;
            
          
        }

        public double PorcentajeCompletado { get { return TareasCompletadas/TareasTotales; } set { this.PorcentajeCompletado = TareasCompletadas / TareasTotales; } }

        public string NombreCategoria { get { return nombreCategoria; } set { } }

        [AlsoNotifyFor("TareasTotales", "TareasCompletadas", "PorcentajeCompletado")]
        public ObservableCollection<Tarea> ListaTareas { get { return listaTareas; } set{ 
                ; 
            } }
    }
}
