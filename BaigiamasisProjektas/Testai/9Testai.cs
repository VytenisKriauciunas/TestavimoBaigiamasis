using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using AutoPaskaitos.BaigiamasisProjektas.Testai;

namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class DevyniTestai
    {
        private Metodai metodai;

        private MetodaiKaunas metodaiKaunas;

        private MetodaiHumanitas metodaiHumantitas;

        [Test]

        public void Humanitas()
        {

            metodaiHumantitas.PriesKiekvienaTestaHuman();
            metodaiHumantitas.Bumblauskas();
            metodaiHumantitas.poKiekvienoTesto();

            metodaiHumantitas.PriesKiekvienaTestaHuman();
            metodaiHumantitas.PrisijungimasIrKrepselis();
            metodaiHumantitas.poKiekvienoTesto();

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
            metodaiKaunas.priesKiekvienaTestaKaunas();
            metodaiKaunas.Sabonis();
            metodaiKaunas.poKiekvienoTesto();

            metodaiKaunas.priesKiekvienaTestaKaunas();
            metodaiKaunas.FormosUzsakymas();
            metodaiKaunas.poKiekvienoTesto();

            metodaiKaunas.priesKiekvienaTestaKaunas();
            metodaiKaunas.Turizmopuslapis();
            metodaiKaunas.poKiekvienoTesto();

        }


    }
}
