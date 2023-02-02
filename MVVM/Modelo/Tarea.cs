using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Administrador_de_tareas.MVVM.Modelo
{
    [AddINotifyPropertyChangedInterface]
    class Tarea
    {
        private string textTarea;
        private bool completada;

        public string TextTarea { get { return textTarea; } set { textTarea = value; } }

        public bool Completada { get { return completada; } set { completada = value; } }
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
