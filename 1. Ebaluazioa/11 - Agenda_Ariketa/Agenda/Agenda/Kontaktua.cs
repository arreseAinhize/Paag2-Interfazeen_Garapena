using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public class Kontaktua
    {
        public string izena { get; set; }
        public string abizena { get; set; }
        public int telefonoa { get; set; }
        public string generoa { get; set; }
        public int prefijoa { get; set; }



        // Constructor
        public Kontaktua(){ }
        public Kontaktua(string izena, string abizena, int telefonoa, string generoa, int prefijoa)
        {
            this.izena = izena;
            this.abizena = abizena;
            this.telefonoa = telefonoa;
            this.generoa = generoa;
            this.prefijoa = prefijoa;
        }

        // Inicializar la lista de contactos correctamente
        public static List<Kontaktua> kontaktuak { get; set; } = new List<Kontaktua>
        {
            new Kontaktua("Jon", "Garcia", 123456789, "Mutila", 34),
            new Kontaktua("Maria", "Lopez", 987654321, "Neska", 34),
            new Kontaktua("Luis", "Martinez", 456789123, "Non-binary", 34),
            new Kontaktua("Ana", "Gonzalez", 789123456, "Beste bat", 34),
            new Kontaktua("Anebalos", "Gonzalez", 123654785, "Beste bat", 22),
            new Kontaktua("Pepito", "Grillo", 256398741, "Beste bat", 22)
        };


        // Método para añadir contactos a la lista
        public static void kontaktuakGehitu(string izena, string abizena, int telefonoa, string generoa, int prefijoa)
        {
            kontaktuak.Add(new Kontaktua(izena, abizena, telefonoa, generoa, prefijoa));
            MessageBox.Show("Kontaktua ondo gehitu da.");
        }

        // Listatik datuak atara
        public static List<Kontaktua> kontaktuakBistaratu()
        {
            return kontaktuak;
        }

        // kontaktua bilatu
        public static Kontaktua KontaktuaBilatu(int telf)
        {
            foreach (var kontaktua in kontaktuak)
            {
                if (kontaktua.telefonoa == telf)
                {
                    return kontaktua;
                }
            }
            return null;
        }
    }
}
