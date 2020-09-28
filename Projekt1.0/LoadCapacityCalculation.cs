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
        private Double ksiEff = 0.0;
        private Double ksiEffM = 0.0;
        private Double as1y = 0.0;
        private Double as1yProv = 0.0;
        private Double as2y = 0.0;
        private Double as2yProv = 0.0;
        private Double niCEff = 0.0;
        private Double niCEffMax = 0.0;
        private Double niEff = 0.0;

        private Double ksiEffZ = 0.0;
        private Double ksiEffMZ = 0.0;
        private Double as1z = 0.0;
        private Double as1zProv = 0.0;
        private Double as2z = 0.0;
        private Double as2zProv = 0.0;
        private Double niCEffZ = 0.0;
        private Double niCEffMaxZ = 0.0;
        private Double niEffZ = 0.0;

        private Double quantity1y = 0.0;
        private Double quantity2y = 0.0;
        private Double quantity1z = 0.0;
        private Double quantity2z = 0.0;

        private Double ro = 0.0;

        private Tables tables = new Tables();
        public event PropertyChangedEventHandler PropertyChanged;

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

        public Double As1yV
        {
            get
            {
                return as1y*10000;
            }
        }

        public Double As1yProv
        {
            get
            {
                return as1yProv;
            }
        }

        public Double As1yProvV
        {
            get
            {
                return as1yProv*10000;
            }
        }
    
        public Double As2y
        {
            get
            {
                return as2y;
            }
        }

        public Double As2yV
        {
            get
            {
                return as2y * 10000;
            }
        }

        public Double As2yProv
        {
            get
            {
                return as2yProv;
            }
        }

        public Double As2yProvV
        {
            get
            {
                return as2yProv * 10000;
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

        public Double KsiEffZ
        {
            get
            {
                return ksiEffZ;
            }
        }

        public Double KsiEffMZ
        {
            get
            {
                return ksiEffMZ;
            }
        }

        public Double As1z
        {
            get
            {
                return as1z;
            }
        }

        public Double As1zV
        {
            get
            {
                return as1z * 10000;
            }
        }

        public Double As1zProv
        {
            get
            {
                return as1zProv;
            }
        }

        public Double As1zProvV
        {
            get
            {
                return as1zProv * 10000;
            }
        }

        public Double As2z
        {
            get
            {
                return as2z;
            }
        }

        public Double As2zV
        {
            get
            {
                return as2z * 10000;
            }
        }

        public Double As2zProv
        {
            get
            {
                return as2zProv;
            }
        }

        public Double As2zProvV
        {
            get
            {
                return as2zProv * 10000;
            }
        }

        public Double NiCEffZ
        {
            get
            {
                return niCEffZ;
            }
        }

        public Double NiCEffMaxZ
        {
            get
            {
                return niCEffMaxZ;
            }
        }

        public Double NiEffZ
        {
            get
            {
                return niEffZ;
            }
        }

        public Double Ro
        {
            get
            {
                return ro;
            }
        }


        public void Calculate(Project project)
        {
            // KIERUNEK Y

            ksiEff = project.Column.Steel.KsiEffLim;

            as2y =
                (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es1y - ksiEff * (1 - 0.5 * ksiEff)
                * project.BasicCalculations.D1y * 0.01 * 0.01 * project.BasicCalculations.D1y * project.Column.Dimension.Width * 0.01 * project.BasicCalculations.Fcd * 1000)
                / ((project.BasicCalculations.D1y * 0.01 - project.BasicCalculations.A2y * 0.001) * project.BasicCalculations.Fyd * 1000);      //m2

            quantity2y = as2y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
            quantity2y = Math.Max(Math.Ceiling((Double)quantity2y), 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2y"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2y"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yV"));

            if (as2y <=  project.BasicCalculations.AreaAsmin * 0.000001)
            {
                quantity2y = project.BasicCalculations.AreaAsmin * 0.000001 / (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                quantity2y = Math.Max(2, Math.Ceiling((Double)quantity2y));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2y"));

                as2yProv = quantity2y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yProv"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yProvV"));

                niEff = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es1y - as2yProv * (0.01 * project.BasicCalculations.D1y - project.BasicCalculations.A2y * 0.001) * project.BasicCalculations.Fyd * 1000)
                    / (project.Column.Dimension.Width * 0.01 * 0.01 * project.BasicCalculations.D1y * 0.01 * project.BasicCalculations.D1y * project.BasicCalculations.Fcd * 1000);

                //tabela 4.8 

                ksiEff = tables.setKsi48(niEff);

                if (ksiEff < 2 * project.BasicCalculations.A2y * 0.001 / 0.01 * project.BasicCalculations.D1y)
                {
                    as1y = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es2y)
                        / (project.BasicCalculations.Fyd * 1000 * (0.01 * project.BasicCalculations.D1y - project.BasicCalculations.A2y * 0.001));

                    quantity1y = as1y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    quantity1y = Math.Max(2, Math.Ceiling((Double)quantity1y));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                    as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProvV"));
                }
                else
                {
                    as1y = ((ksiEff * 0.01 * project.BasicCalculations.D2y * project.Column.Dimension.Width * 0.01 * project.BasicCalculations.Fcd * 1000) + (as2yProv * project.BasicCalculations.Fyd * 1000) - project.Column.Statics.CompressiveForce) / project.BasicCalculations.Fyd * 1000;

                    quantity1y = as1y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    quantity1y = Math.Max(2, Math.Ceiling((Double)quantity1y));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                    as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProvV"));
                }
            }

            else
            {
                as1y = (project.Column.Steel.KsiEffLim * project.BasicCalculations.D1y * 0.01 * project.Column.Dimension.Width * 0.01 * project.BasicCalculations.Fcd * 1000 + as2y * project.BasicCalculations.Fyd * 1000 - project.Column.Statics.CompressiveForce) / (project.BasicCalculations.Fyd * 1000);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1y"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yV"));

                if (as1y > 0)
                {
                    quantity1y = as1y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    quantity1y = Math.Max(Math.Ceiling((Double)quantity1y), 2);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                    as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProvV"));
                }
                else
                {
                    //MAŁY MIMOŚRÓD
                    niCEff = project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es2y / (project.Column.Dimension.Width * 0.01 * project.BasicCalculations.D1y * 0.01 * project.BasicCalculations.D1y * 0.01 * project.BasicCalculations.Fcd * 1000);

                    //tabela 5.1
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
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProvV"));
                        }
                       
                        else
                        {
                            quantity1y = as1y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                            quantity1y = Math.Max(2, Math.Ceiling((Double)quantity1y));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                            as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProvV"));
                        }
                    }

                    else
                    {
                        as1y = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es2y - 0.5 * project.BasicCalculations.D1y * 0.01 * project.BasicCalculations.D1y * 0.01 * project.Column.Dimension.Width * 0.01 * project.BasicCalculations.Fcd * 1000)
                            / ((-1) * project.BasicCalculations.Fyd * 1000 * (0.01 * project.BasicCalculations.D1y - project.BasicCalculations.A2y * 0.001)); //m2
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1y"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yV"));
                    }

                    as2y = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es1y - ksiEffM * (1 - 0.5 * ksiEffM) * Math.Pow(project.BasicCalculations.D1y * 0.01, 2 ) * 0.01 * project.Column.Dimension.Width * project.BasicCalculations.Fcd * 1000)
                        / (project.BasicCalculations.Fyd * 1000 * (0.01 * project.BasicCalculations.D1y - project.BasicCalculations.A2y * 0.001)); //m2
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2y"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yV"));

                    quantity2y = as2y / (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                    quantity2y = Math.Max(2, Math.Ceiling((Double)quantity2y));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2y"));

                    as2yProv = quantity2y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yProv"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yProvV"));
                }
            }

            if (as1yProv < project.BasicCalculations.AreaAsmin * 0.000001)
            {
                quantity1y += 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1y"));

                as1yProv = quantity1y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1y) / 2) * ((project.Column.Diameters.Fi1y) / 2));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProv"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1yProvV"));
            }

            if (as2yProv < project.BasicCalculations.AreaAsmin * 0.000001)
            {
                quantity2y += 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2y"));

                as2yProv = quantity2y * (0.000001 * Math.PI * ((project.Column.Diameters.Fi2y) / 2) * ((project.Column.Diameters.Fi2y) / 2));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yProv"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2yProvV"));
            }

            // KIERUNEK Z

            ksiEff = project.Column.Steel.KsiEffLim;

            as2z =
                (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es1z - ksiEff * (1 - 0.5 * ksiEff)
                * project.BasicCalculations.D1z * 0.01 * 0.01 * project.BasicCalculations.D1z * project.Column.Dimension.Height * 0.01 * project.BasicCalculations.Fcd * 1000)
                / ((project.BasicCalculations.D1z * 0.01 - project.BasicCalculations.A2z * 0.001) * project.BasicCalculations.Fyd * 1000);      //m2
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2z"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2zV"));


            quantity2z = as2z / (0.000001 * Math.PI * ((project.Column.Diameters.Fi2z) / 2) * ((project.Column.Diameters.Fi2z) / 2));
            quantity2z = Math.Max(Math.Ceiling((Double)quantity2z), 2);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2z"));

            if (as2z <=  project.BasicCalculations.AreaAsmin * 0.000001)
            {
                quantity2z = project.BasicCalculations.AreaAsmin * 0.000001 / (0.000001 * Math.PI * ((project.Column.Diameters.Fi2z) / 2) * ((project.Column.Diameters.Fi2z) / 2));
                quantity2z = Math.Max(2, Math.Ceiling((Double)quantity2z));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2z"));

                as2zProv = quantity2z * (0.000001 * Math.PI * ((project.Column.Diameters.Fi2z) / 2) * ((project.Column.Diameters.Fi2z) / 2));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2zProv"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2zProvV"));

                niEffZ = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es1z - as2zProv * (0.01 * project.BasicCalculations.D1z - project.BasicCalculations.A2z * 0.001) * project.BasicCalculations.Fyd * 1000)
                    / (project.Column.Dimension.Height * 0.01 * 0.01 * project.BasicCalculations.D1z * 0.01 * project.BasicCalculations.D1z * project.BasicCalculations.Fcd * 1000);

                //tabela 4.8
                ksiEffZ = tables.setKsi48(niEffZ);

                if (ksiEffZ < 2 * project.BasicCalculations.A2z * 0.001 / 0.01 * project.BasicCalculations.D1z)
                {
                    as1z = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es2z)
                        / (project.BasicCalculations.Fyd * 1000 * (0.01 * project.BasicCalculations.D1z - project.BasicCalculations.A2z * 0.001));

                    quantity1z = as1z / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                    quantity1z = Math.Max(2, Math.Ceiling((Double)quantity1z));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1z"));

                    as1zProv = quantity1z * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProv"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProvV"));
                }

                else
                {
                    as1z = ((ksiEffZ * 0.01 * project.BasicCalculations.D2z * project.Column.Dimension.Height * 0.01 * project.BasicCalculations.Fcd * 1000) + (as2zProv * project.BasicCalculations.Fyd * 1000) - project.Column.Statics.CompressiveForce) / project.BasicCalculations.Fyd * 1000;

                    quantity1z = as1z / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                    quantity1z = Math.Max(2, Math.Ceiling((Double)quantity1z));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1z"));

                    as1zProv = quantity1z * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProv"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProvV"));
                }

            }

            else
            {
                as1z = (project.Column.Steel.KsiEffLim * project.BasicCalculations.D1z * 0.01 * project.Column.Dimension.Height * 0.01 * project.BasicCalculations.Fcd * 1000 + as2z * project.BasicCalculations.Fyd * 1000 - project.Column.Statics.CompressiveForce) / (project.BasicCalculations.Fyd * 1000);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1z"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zV"));

                if (as1z > 0)
                {
                    quantity1z = as1z / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                    quantity1z = Math.Max(Math.Ceiling((Double)quantity1z), 2);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1z"));

                    as1zProv = quantity1z * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProv"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProvV"));
                }

                else
                {
                    //MAŁY MIMOŚRÓD
                    niCEffZ = project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es2z / (project.Column.Dimension.Height * 0.01 * project.BasicCalculations.D1z * 0.01 * project.BasicCalculations.D1z * 0.01 * project.BasicCalculations.Fcd * 1000);

                    //tabela 5.1
                    niCEffMaxZ = tables.niCeffMax(project.BasicCalculations.A2z / project.BasicCalculations.D1z);
                    ksiEffMZ = tables.ksieffM(project.BasicCalculations.A2z / project.BasicCalculations.D1z, niCEffZ);

                    if (niCEffZ < niCEffMaxZ)
                    {
                        as1z = project.BasicCalculations.AreaAsmin * 0.000001 - as2z;

                        if (as1z < 0)
                        {
                            quantity1z = 2;
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1z"));

                            as1zProv = quantity1z * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProv"));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProvV"));
                        }

                        else
                        {
                            quantity1z = as1z / (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                            quantity1z = Math.Max(2, Math.Ceiling((Double)quantity1z));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1z"));

                            as1zProv = quantity1z * (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProv"));
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProvV"));
                        }
                    }

                    else
                    {
                        as1z = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es2z - 0.5 * project.BasicCalculations.D1z * 0.01 * project.BasicCalculations.D1z * 0.01 * project.Column.Dimension.Height * 0.01 * project.BasicCalculations.Fcd * 1000)
                            / ((-1) * project.BasicCalculations.Fyd * 1000 * (0.01 * project.BasicCalculations.D1z - project.BasicCalculations.A2z * 0.001)); //m2
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1z"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zV"));
                    }

                    as2z = (project.Column.Statics.CompressiveForce * project.SecondOrderCalculations.Es1z - ksiEffMZ * (1 - 0.5 * ksiEffMZ) * Math.Pow(project.BasicCalculations.D1z * 0.01, 2) * 0.01 * project.Column.Dimension.Height * project.BasicCalculations.Fcd * 1000)
                        / (project.BasicCalculations.Fyd * 1000 * (0.01 * project.BasicCalculations.D1z - project.BasicCalculations.A2z * 0.001)); //m2
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2z"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2zV"));

                    quantity2z = as2z / (0.000001 * Math.PI * ((project.Column.Diameters.Fi2z) / 2) * ((project.Column.Diameters.Fi2z) / 2));
                    quantity2z = Math.Max(2, Math.Ceiling((Double)quantity2z));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2z"));

                    as2zProv = quantity2z * (0.000001 * Math.PI * ((project.Column.Diameters.Fi2z) / 2) * ((project.Column.Diameters.Fi2z) / 2));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2zProv"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2zProvV"));
                }
            }

            if (as1zProv < project.BasicCalculations.AreaAsmin * 0.000001)
            {
                quantity1z += 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity1z"));

                as1zProv = quantity1z* (0.000001 * Math.PI * ((project.Column.Diameters.Fi1z) / 2) * ((project.Column.Diameters.Fi1z) / 2));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProv"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As1zProvV"));
            }

            if (as2zProv < project.BasicCalculations.AreaAsmin * 0.000001)
            {
                quantity2z += 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity2z"));

                as2zProv = quantity2z * (0.000001 * Math.PI * ((project.Column.Diameters.Fi2z) / 2) * ((project.Column.Diameters.Fi2z) / 2));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2zProv"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("As2zProvV"));
            }

            ro = 10000*(as1yProv + as2yProv + as1zProv + as2zProv) / (project.Column.Dimension.Width * project.Column.Dimension.Height);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ro"));
        }
    }
}

