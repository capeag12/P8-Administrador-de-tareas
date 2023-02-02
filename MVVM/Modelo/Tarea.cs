using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P8_Administrador_de_tareas.MVVM.Modelo
{
    [AddINotifyPropertyChangedInterface]
    class Tarea
    {
        public string textTarea;
        public bool completada;

        public string TextTarea { get { return textTarea; } set { textTarea = value; } }

        
        public bool Completada { get { return completada; } 
            set 
            { 
                completada = value;
            } }
        public Tarea(string tarea)
        {
            this.textTarea = tarea;
            completada = false;
            
        }

        void completarTarea()
        {
            this.completada= true;
            
        }

    }
}
