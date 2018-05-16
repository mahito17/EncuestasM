using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Encuestas
{
   public class Datos:Notificable
    {
        #region Atributos
        private ObservableCollection<Encuesta> encuestas;
        
        #endregion
        public Datos() {   //Cosntructor

        }
        public ObservableCollection<Encuesta> Encuestas
        {
            get
            {
                return encuestas;//Atributo
            }
            set
            {
                if (encuestas == value)
                {
                    return;
                }
                encuestas = value;
                OnPropertyChanged();
            }
        }

    }
}
