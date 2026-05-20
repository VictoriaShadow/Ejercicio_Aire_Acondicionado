using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Aire_Acondicionado
{
    public class AireAcondicionado
    {
        private string _Marca;
        private int _Frigorias;
        private bool _Split;
        private string _Pais;
        private bool _FrioSolo;
        private int _Temperatura;
        private bool _Encendido;

        public AireAcondicionado(string marca, int frigorias, bool split, string pais, bool frioSolo)
        {
            _Marca = marca;
            _Frigorias = frigorias;
            _Split = split;
            _Pais = pais.ToUpper();
            _FrioSolo = frioSolo;
        }
            public bool Encendido
        {
            get { return _Encendido; }
         }
            public int Temperatura
         {
            get { return _Temperatura; }
         }
            public string Modelo
        {
            get{
                string modelo = "";
                modelo += _Marca.Substring(0, 3).ToUpper();
                modelo += _Frigorias;
                modelo += _Pais.Substring(0, 3).ToUpper();
                if (_FrioSolo)
                {
                    modelo += "FS";
                } else
                {
                    modelo += "FC";
                }
                if (_Split)
                {
                    modelo += "/S";
                }
                return modelo;
            }
        }

        //Métodos
        public void Power() { 
            _Encendido = !_Encendido; 
        }
        public void Subir(int grados)
        {
            if (_Encendido == true)
            {
                int max;
                if (_FrioSolo == true)
                {
                    max = 24;
                }
                else
                {
                    max = 30;
                }
                if (_Split == true)
                {
                    max++;
                }
                _Temperatura += grados;
                if (_Temperatura > max)
                {
                    _Temperatura = max;
                }

            }
            else
            {
                Console.WriteLine("No se puede cambiar la temperatura con el dispositivo apagado");
            }
        }
        public void Subir()
        {
            if (_Encendido == true)
            {
                if (_FrioSolo == true)
                {
                    _Temperatura = 24;
                }
                else
                {
                    _Temperatura = 30;
                }
                if (_Split == true)
                {
                    _Temperatura += 1;
                }
            }
            else
            {
                Console.WriteLine("No se puede cambiar la temperatura con el dispositivo apagado");
            }
        }
        public void Bajar(int grados)
        {
            if (_Encendido == true)
            {
                int min = 18;
            int max;
            if (_FrioSolo == true)
            {
                max = 24;
            }
            else
            {
                max = 30;
            }
            if (_Split == true)
            {
                min--;
                max++;
            }
            _Temperatura -= grados;
            if (_Temperatura < min)
            {
                _Temperatura = min;
            } }
            else
            {
                Console.WriteLine("No se puede cambiar la temperatura con el dispositivo apagado");
            }
}
        public void Bajar()
        {
            if (_Encendido == true)
            {
                _Temperatura = 18;
            if (_Split == true)
            {
                _Temperatura -= 1;
            }
            }
            else
            {
                Console.WriteLine("No se puede cambiar la temperatura con el dispositivo apagado");
            }
        }
    }
}