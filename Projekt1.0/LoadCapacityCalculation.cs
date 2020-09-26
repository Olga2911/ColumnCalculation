using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1._0
{
    class LoadCapacityCalculation : INotifyPropertyChanged
    {
        //WYMIAROWANIE ZBROJENIA
        private Double ksiEff = 0.0;
        private Double ksiEffM = 0.0;
        private Double as1y = 0.0;
        private Double as1yProv = 0.0;
        private Double as2y = 0.0;
        private Double as2yProv = 0.0;
        private Double niCEff = 0.0;
        private Double niCEffMax = 0.0;
        private Double niEff = 0.0;

        private Double quantity1y = 0.0;
        private Double quantity2y = 0.0;
        private Double quantity1z = 0.0;
        private Double quantity2z = 0.0;

        private Tables tables;
        public event PropertyChangedEventHandler PropertyChanged;

        public LoadCapacityCalculation(Project project)
        {
            Calculate(project);
        }

        public Double KsiEff
        {
            get
            {
                return ksiEff;
            }
        }

        public Double KsiEffM
        {
            get
            {
                return ksiEffM;
            }
        }

        public Double As1y
        {
            get
            {
                return as1y;
            }
        }

        public Double As1yProv
        {
            get
            {
                return as1yProv;
            }
        }

        public Double As2y
        {
            get
            {
                return as2y;
            }
        }

        public Double As2yProv
        {
            get
            {
                return as2yProv;
            }
        }

        public Double NiCEff
        {
            get
            {
                return niCEff;
            }
        }

        public Double NiCEffMax
        {
            get
            {
                return niCEffMax;
            }
        }

        public Double NiEff
        {
            get
            {
                return niEff;
            }
        }

        public Double Quantity1y
        {
            get
            {
                return quantity1y;
            }
        }

        public Double Quantity2y
        {
            get
            {
                return quantity2y;
            }
        }

        public Double Quantity1z
        {
            get
            {
                return quantity1z;
            }
        }

        public Double Quantity2z
        {
            get
            {
                return quantity2z;
            }
        }

        public void Calculate(Project project)
        {
            ksiEff = project.Column.Steel.KsiEffLim;
            //ksiEff = Math.Round((Double)ksiEff, 3);

            as2y =
                (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es1y - ksiEff * (1 - 0.5 * ksiEff)
                * project.BasicCalculations.D1y * 0.01 * 0.01 * project.BasicCalculations.D1y * project.Column.Dimension.Width * 0.01 * project.BasicCalculations.Fcd * 1000)
                / ((project.BasicCalculations.D1y * 0.01 - project.BasicCalculations.A2y * 0.001) * project.BasicCalculations.Fyd * 1000);      //m2

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2y"));

            if (as2y <= 0.5 * project.BasicCalculations.AreaAsmin * 0.000001)
            {
                quantity2y = as2y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                quantity2y = Math.Max(2, Math.Ceiling((Double)quantity2y));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2y"));

                as2yProv = quantity2y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yProv"));

                niEff = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es1y - as2yProv * (0.01 * project.BasicCalculations.D1y - project.BasicCalculations.A2y * 0.001) * project.BasicCalculations.Fyd * 1000)
                    / (project.Column.Dimension.Width * 0.01 * 0.01 * project.BasicCalculations.D1y * 0.01 * project.BasicCalculations.D1y * project.BasicCalculations.Fcd * 1000);

                //tabela 4.8 zal2 z ni
                ksiEff = tables.setKsi48(niCEff);

                if (ksiEff < 2 * project.BasicCalculations.A2y * 0.001 / 0.01 * project.BasicCalculations.D1y)
                {
                    as1y = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es2y)
                        / (project.BasicCalculations.Fyd * 1000 * (0.01 * project.BasicCalculations.D1y - project.BasicCalculations.A2y * 0.001));

                    quantity1y = as1y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    quantity1y = Math.Max(2, Math.Ceiling((Double)quantity1y));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                    as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));
                }
                else
                {
                    as1y = ((ksiEff * 0.01 * project.BasicCalculations.D2y * project.Column.Dimension.Width * 0.01 * project.BasicCalculations.Fcd * 1000) + (as2yProv * project.BasicCalculations.Fyd * 1000) - project.Column.Statics.CompressiveForce) / project.BasicCalculations.Fyd * 1000;

                    quantity1y = as1y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    quantity1y = Math.Max(2, Math.Ceiling((Double)quantity1y));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                    as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));

                }

            }
            else
            {
                as1y = (project.Column.Steel.KsiEffLim * project.BasicCalculations.D1y * 0.01 * project.Column.Dimension.Width * 0.01 * project.BasicCalculations.Fcd * 1000 + as2y * project.BasicCalculations.Fyd * 1000 - project.Column.Statics.CompressiveForce) / (project.BasicCalculations.Fyd * 1000);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1y"));

                if (as1y > 0)
                {
                    quantity1y = as1y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    quantity1y = Math.Max(Math.Ceiling((Double)quantity1y), 2);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                    as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));
                }
                else
                {
                    //MAŁY MIMOŚRÓD
                    niCEff = project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es2y / (project.Column.Dimension.Width * 0.01 * project.BasicCalculations.D1y * 0.01 * project.BasicCalculations.D1y * 0.01 * project.BasicCalculations.Fcd * 1000);

                    //tabelka 5.1
                    niCEffMax = tables.niCeffMax(project.BasicCalculations.A2y / project.BasicCalculations.D1y);
                    ksiEffM = tables.ksieffM(project.BasicCalculations.A2y / project.BasicCalculations.D1y, niCEff); 

                    if (niCEff < niCEffMax)
                    {
                        as1y = project.BasicCalculations.AreaAsmin * 0.000001 - as2y;

                        if (as1y < 0)
                        {
                            quantity1y = 2;
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                            as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));
                        }

                        else
                        {
                            quantity1y = as1y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                            quantity1y = Math.Max(2, Math.Ceiling((Double)quantity1y));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                            as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));

                        }
                    }
                    else
                    {
                        as1y = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es2y - 0.5 * project.BasicCalculations.D1y * 0.01 * project.BasicCalculations.D1y * 0.01 * project.Column.Dimension.Width * 0.01 * project.BasicCalculations.Fcd * 1000)
                            / ((-1) * project.BasicCalculations.Fyd * 1000 * (0.01 * project.BasicCalculations.D1y - project.BasicCalculations.A2y * 0.001)); //m2
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1y"));
                    }

                    as2y = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es1y - ksiEffM * (1 - 0.5 * ksiEffM) * Math.Pow(project.BasicCalculations.D1y * 0.01, 2 ) * 0.01 * project.Column.Dimension.Width * project.BasicCalculations.Fcd * 1000)
                        / (project.BasicCalculations.Fyd * 1000 * (0.01 * project.BasicCalculations.D1y - project.BasicCalculations.A2y * 0.001)); //m2
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2y"));

                    quantity2y = as2y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                    quantity2y = Math.Max(2, Math.Ceiling((Double)quantity2y));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2y"));

                    as2yProv = quantity2y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yProv"));

                }
            }

            if (as1yProv < project.BasicCalculations.AreaAsmin * 0.000001)
            {
                quantity1y += 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));

            }

            if (as2yProv < project.BasicCalculations.AreaAsmin * 0.000001)
            {
                quantity2y += 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2y"));

                as2yProv = quantity2y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yProv"));

            }

        }
    }
}

