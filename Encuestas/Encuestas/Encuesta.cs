using System;
using System.Collections.Generic;
using System.Text;

namespace Encuestas
{
    public class Encuesta
    {
        #region Atributo
        public string equipoFavorito;
        #endregion
        #region Propiedades
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EquipoFavorito
        {
            get
            {
                return equipoFavorito;
            }
            set
            {
                equipoFavorito = value;
                switch (equipoFavorito)
                {
                    case " Colombia":
                        Color = "Yellow";
                        break;
                    case "Peru":
                        Color = "Blue";
                        break;
                    case "Brasil":
                        Color = "Red";
                        break;
                    case "Rusia":
                        Color = "Green";
                        break;
                    case "Alemania":
                        Color = "Orange";
                        break;
                    case "Argentina":
                        Color = "Purple";
                        break;
                }

            }
        }
        public string Color { get; set; }
        #endregion

        #region Metodos

        public override string ToString()
        {
            return $"{Nombre}|{FechaNacimiento}|{EquipoFavorito}";
        }

        #endregion
    }
}
