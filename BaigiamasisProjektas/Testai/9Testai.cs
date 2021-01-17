using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using AutoPaskaitos.BaigiamasisProjektas.Testai;

namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class _9Testai
    {
        private Metodai metodai;

        [Test]

        public void Humanitas()
        {

            metodai.PriesKiekvienaTestaHuman();
            metodai.Bumblauskas();
            metodai.poKiekvienoTesto();

            metodai.PriesKiekvienaTestaHuman();
            metodai.PrisijungimasIrKrepselis();
            metodai.poKiekvienoTesto();

        }

        [Test]
        public void Kika()
        {
            metodai.PriesKiekvienaTestaKika();
            metodai.kirpyklos();
            metodai.poKiekvienoTesto();

            metodai.PriesKiekvienaTestaKika();
            metodai.PrisijungimoTestas();
            metodai.poKiekvienoTesto();

            metodai.PriesKiekvienaTestaKika();
            metodai.Paieska();
            metodai.poKiekvienoTesto();

            metodai.PriesKiekvienaTestaKika();
            metodai.ArEsuTinkamamePuslapyje();
            metodai.poKiekvienoTesto();

        }

        [Test]

        public void Kaunas()
        {
            metodai.priesKiekvienaTestaKaunas();
            metodai.Sabonis();
            metodai.poKiekvienoTesto();

            metodai.priesKiekvienaTestaKaunas();
            metodai.FormosUzsakymas();
            metodai.poKiekvienoTesto();

            metodai.priesKiekvienaTestaKaunas();
            metodai.Turizmopuslapis();
            metodai.poKiekvienoTesto();

        }


    }
}
