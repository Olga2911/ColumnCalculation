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
        //private Double sy = 0.0;
        //private Double sz = 0.0;
        //private Double nEdy = 0.0;
        //private Double nEdz = 0.0;
        //private Double alfa1y = 0.0;
        //private Double alfa2y = 0.0;
        //private Double alfa1z = 0.0;
        //private Double alfa2z = 0.0;
        //private Double delta1y = 0.0;
        //private Double delta2y = 0.0;
        //private Double delta1z = 0.0;
        //private Double delta2z = 0.0;

        //private Double cParameterCapacityY = 0.0;
        //private Double ksiY = 0.0;
        //private Double k2Y = 0.0;
        //private Double mRd1Y = 0.0;
        //private Double mRdY = 0.0;
        //private Double bNY= 0.0;
        //private Double kParameterCapacityY = 0.0;

        //private Double cParameterCapacityZ = 0.0;
        //private Double ksiZ = 0.0;
        //private Double k2Z = 0.0;
        //private Double mRd1Z = 0.0;
        //private Double mRdZ = 0.0;
        //private Double bNZ = 0.0;
        //private Double kParameterCapacityZ = 0.0;

        //private String loadCapacityCheckingCommentY;
        //private String loadCapacityCheckingCommentZ;
        //private String loadCapacityCheckingWarningY;
        //private String loadCapacityCheckingWarningZ;
        ////private String loadCapacityCheckingCaseInformationY;
        ////private String loadCapacityCheckingCaseInformationZ;

        public event PropertyChangedEventHandler PropertyChanged;

        //public LoadCapacityCalculation (Project project)
        //{
        //    Calculate(project);
        //}

        //public Double Sy
        //{
        //    get
        //    {
        //        return sy;
        //    }
        //}

        //public Double Sz
        //{
        //    get
        //    {
        //        return sz;
        //    }
        //}

        //public Double NEdy
        //{
        //    get
        //    {
        //        return nEdy;
        //    }
        //}

        //public Double NEdz
        //{
        //    get
        //    {
        //        return nEdz;
        //    }
        //}

        //public Double Alfa1y
        //{
        //    get
        //    {
        //        return alfa1y;
        //    }
        //}

        //public Double Alfa2y
        //{
        //    get
        //    {
        //        return alfa2y;
        //    }
        //}

        //public Double Alfa1z
        //{
        //    get
        //    {
        //        return alfa1z;
        //    }
        //}

        //public Double Alfa2z
        //{
        //    get
        //    {
        //        return alfa2z;
        //    }
        //}

        //public Double Delta1y
        //{
        //    get
        //    {
        //        return delta1y;
        //    }
        //}

        //public Double Delta2y
        //{
        //    get
        //    {
        //        return delta2y;
        //    }
        //}

        //public Double Delta1z
        //{
        //    get
        //    {
        //        return delta1z;
        //    }
        //}

        //public Double Delta2z
        //{
        //    get
        //    {
        //        return delta2z;
        //    }
        //}

        //public Double CParameterCapacityY
        //{
        //    get
        //    {
        //        return cParameterCapacityY;
        //    }
        //}

        //public Double KsiY
        //{
        //    get
        //    {
        //        return ksiY;
        //    }
        //}

        //public Double K2Y
        //{
        //    get
        //    {
        //        return k2Y;
        //    }
        //}

        //public Double MRd1Y
        //{
        //    get
        //    {
        //        return mRd1Y;
        //    }
        //}

        //public Double MRdY
        //{
        //    get
        //    {
        //        return mRdY;
        //    }
        //}

        //public Double BNY
        //{
        //    get
        //    {
        //        return bNY;
        //    }
        //}

        //public Double KParameterCapacityY
        //{
        //    get
        //    {
        //        return kParameterCapacityY;
        //    }
        //}

        //public Double CParameterCapacityZ
        //{
        //    get
        //    {
        //        return cParameterCapacityZ;
        //    }
        //}

        //public Double KsiZ
        //{
        //    get
        //    {
        //        return ksiZ;
        //    }
        //}

        //public Double K2Z
        //{
        //    get
        //    {
        //        return k2Z;
        //    }
        //}

        //public Double MRd1Z
        //{
        //    get
        //    {
        //        return mRd1Z;
        //    }
        //}

        //public Double MRdZ
        //{
        //    get
        //    {
        //        return mRdZ;
        //    }
        //}

        //public Double BNZ
        //{
        //    get
        //    {
        //        return bNZ;
        //    }
        //}

        //public Double KParameterCapacityZ
        //{
        //    get
        //    {
        //        return kParameterCapacityZ;
        //    }
        //}

        //public String LoadCapacityCheckingCommentY
        //{
        //    get
        //    {
        //        return loadCapacityCheckingCommentY;
        //    }
        //    set
        //    {
        //        loadCapacityCheckingCommentY = value;
        //    }
        //}

        //public String LoadCapacityCheckingCommentZ
        //{
        //    get
        //    {
        //        return loadCapacityCheckingCommentZ;
        //    }
        //    set
        //    {
        //        loadCapacityCheckingCommentZ = value;
        //    }
        //}

        //public String LoadCapacityCheckingWarningY
        //{
        //    get
        //    {
        //        return loadCapacityCheckingWarningY;
        //    }
        //    set
        //    {
        //        loadCapacityCheckingWarningY = value;
        //    }
        //}

        //public String LoadCapacityCheckingWarningZ
        //{
        //    get
        //    {
        //        return loadCapacityCheckingWarningZ;
        //    }
        //    set
        //    {
        //        loadCapacityCheckingWarningZ = value;
        //    }
        //}






        //public void Calculate(Project project)
        //{
        //    sy = project.Column.Dimension.Width*project.BasicCalculations.D1y*project.BasicCalculations.Fcd*0.1;
        //    sy = Math.Round((Double)sy, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sy"));

        //    sz = project.Column.Dimension.Height * project.BasicCalculations.D1z * project.BasicCalculations.Fcd*0.1;
        //    sz = Math.Round((Double)sz, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sz"));

        //    nEdy =project.Column.Statics.CompressiveForce/sy;
        //    nEdy = Math.Round((Double)nEdy, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NEdy"));

        //    nEdz = project.Column.Statics.CompressiveForce / sz;
        //    nEdz = Math.Round((Double)nEdz, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NEdz"));

        //    alfa1y = project.BasicCalculations.AreaAs1y*0.001*project.BasicCalculations.Fyd/sy;
        //    alfa1y = Math.Round((Double)alfa1y, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Alfa1y"));

        //    alfa2y = project.BasicCalculations.AreaAs2y * 0.001 * project.BasicCalculations.Fyd / sy;
        //    alfa2y = Math.Round((Double)alfa2y, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Alfa2y"));

        //    alfa1z = project.BasicCalculations.AreaAs1z * 0.001 * project.BasicCalculations.Fyd / sz;
        //    alfa1z = Math.Round((Double)alfa1z, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Alfa1z"));

        //    alfa2z = project.BasicCalculations.AreaAs2z * 0.001 * project.BasicCalculations.Fyd / sz;
        //    alfa2z = Math.Round((Double)alfa2z, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Alfa2z"));

        //    delta1y = project.BasicCalculations.A1y * 0.1 / project.BasicCalculations.D1y;
        //    delta1y = Math.Round((Double)delta1y, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Delta1y"));

        //    delta2y = project.BasicCalculations.A2y * 0.1 / project.BasicCalculations.D2y;
        //    delta2y = Math.Round((Double)delta2y, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Delta2y"));

        //    delta1z = project.BasicCalculations.A1z * 0.1 / project.BasicCalculations.D1z;
        //    delta1z = Math.Round((Double)delta1z, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Delta1z"));

        //    delta2z = project.BasicCalculations.A2z * 0.1 / project.BasicCalculations.D2z;
        //    delta2z = Math.Round((Double)delta2z, 2);
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Delta2z"));




        //    //KIERUNEK Y

        //    if (NEdy < project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni + alfa2y)
        //    {
        //        // przypadek ct
        //        if ((project.Column.Concrete.Fck <= 50.0) && (project.Column.Steel.Fyk == 500.0)) 
        //        {
        //            cParameterCapacityY = 1.61;
        //        } 
        //        else
        //        {
        //            cParameterCapacityY = 1000*project.Column.Steel.Es*project.Column.Concrete.EpsilonCu2/project.BasicCalculations.Fyd;
        //        }
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CParameterCapacityY"));

        //        ksiY = (nEdy - alfa2y + alfa1y) / (project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni);
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KsiY"));

        //        if ((cParameterCapacityY * (1 - ksiY) / ksiY >= 1) && (cParameterCapacityY * (ksiY - Delta2y) / ksiY)>=1) // warunek I
        //        {
        //            k2Y=Math.Min((cParameterCapacityY * (ksiY - Delta2y) / ksiY), 1);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2Y"));

        //            mRd1Y = project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * ksiY * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda * ksiY) +
        //                +k2Y * alfa2y * (1 - delta2y);
        //            mRd1Y = Math.Round((Double)mRd1Y, 4);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Y"));

        //            mRdY = (mRd1Y - 0.5 * nEdy * (1 - delta1y)) * sy * project.BasicCalculations.D1y*0.01;
        //            mRdY = Math.Round((Double)mRdY, 2);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdY"));
        //        }

        //        else
        //        {
        //            bNY = alfa2y + cParameterCapacityY * alfa1y - nEdy;
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BNY"));

        //            ksiY = (Math.Sqrt(bNY * bNY + 4 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * cParameterCapacityY * alfa1y) - bNY) / (2 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KsiY"));

        //            if ((cParameterCapacityY * (1 - ksiY) / ksiY < 1) && (cParameterCapacityY * (ksiY - Delta2y) / ksiY) >= 1) // warunek II
        //            {
        //                k2Y = Math.Min((cParameterCapacityY * (ksiY - Delta2y) / ksiY), 1);
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2Y"));

        //                mRd1Y = project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * ksiY * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda * ksiY) +
        //                    +k2Y * alfa2y * (1 - delta2y);
        //                mRd1Y = Math.Round((Double)mRd1Y, 4);
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Y"));

        //                mRdY = (mRd1Y - 0.5 * nEdy * (1 - delta1y)) * sy * project.BasicCalculations.D1y*0.01;
        //                mRdY = Math.Round((Double)mRdY, 2);
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdY"));
        //            }

        //            else
        //            {
        //                bNY = cParameterCapacityY * alfa2y - alfa1y - nEdy;
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BNY"));

        //                ksiY = (Math.Sqrt(bNY * bNY + 4 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * cParameterCapacityY * alfa2y*delta2y) - bNY) / (2 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni);
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KsiY"));

        //                if ((cParameterCapacityY * (1 - ksiY) / ksiY >= 1) && (cParameterCapacityY * (ksiY - Delta2y) / ksiY) < 1) //warunek III
        //                {
        //                    k2Y = Math.Min((cParameterCapacityY * (ksiY - Delta2y) / ksiY), 1);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2Y"));

        //                    mRd1Y = project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * ksiY * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda * ksiY) +
        //                        +k2Y * alfa2y * (1 - delta2y);
        //                    mRd1Y = Math.Round((Double)mRd1Y, 4);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Y"));

        //                    mRdY = (mRd1Y - 0.5 * nEdy * (1 - delta1y)) * sy * project.BasicCalculations.D1y*0.01;
        //                    mRdY = Math.Round((Double)mRdY, 2);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdY"));
        //                }

        //                else
        //                {
        //                    bNY = cParameterCapacityY * alfa2y + cParameterCapacityY * alfa1y - nEdy;
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BNY"));

        //                    ksiY = (Math.Sqrt(bNY * bNY + 4 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * (cParameterCapacityY*alfa2y*delta2y+cParameterCapacityY*alfa1y)) - bNY) / (2 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KsiY"));

        //                    mRd1Y = project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * ksiY * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda * ksiY) +
        //                     +k2Y * alfa2y * (1 - delta2y);
        //                    mRd1Y = Math.Round((Double)mRd1Y, 4);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Y"));

        //                    mRdY = (mRd1Y - 0.5 * nEdy * (1 - delta1y)) * sy * project.BasicCalculations.D1y*0.01;
        //                    mRdY = Math.Round((Double)mRdY, 2);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdY"));
        //                }
        //            }
        //        }
        //    }


        //    else
        //    {
        //        //przypadek cc
        //        if ((project.Column.Concrete.Fck <= 50.0) && (project.Column.Steel.Fyk == 500.0))
        //        {
        //            kParameterCapacityY = 0.805;
        //        }
        //        else
        //        {
        //            kParameterCapacityY = Math.Min(1000*project.Column.Steel.Es * project.Column.Concrete.EpsilonC3/ project.BasicCalculations.Fyd, 1);
        //        }
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KParameterCapacityY"));


        //        if (project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni < nEdy && nEdy < project.Column.LoadCapacityParameters.Ni * (1 + delta1y) + kParameterCapacityY * (alfa1y + alfa2y))
        //        {
        //            mRd1Y = Math.Min(project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda) + alfa2y * (1 - delta2y),
        //                0.5 * project.Column.LoadCapacityParameters.Ni * (1 - delta1y * delta1y) + kParameterCapacityY * alfa2y * (1 - delta2y));
        //            mRd1Y = Math.Round((Double)mRd1Y, 4);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Y"));

        //            mRdY = (mRd1Y - 0.5 * nEdy * (1 - delta1y)) * sy * project.BasicCalculations.D1y*0.01;
        //            mRdY = Math.Round((Double)mRdY, 2);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdY"));

        //            if (mRdY < 0)
        //            {
        //                mRdY = 0;
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdY"));
        //            }
        //        }

        //        else
        //        {
        //            //niewiem co ???
        //            mRd1Y = Math.Min(project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda) + alfa2y * (1 - delta2y),
        //            0.5 * project.Column.LoadCapacityParameters.Ni * (1 - delta1y * delta1y) + kParameterCapacityY * alfa2y * (1 - delta2y));
        //            mRd1Y = Math.Round((Double)mRd1Y, 4);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Y"));

        //            mRdY = (mRd1Y - 0.5 * nEdy * (1 - delta1y)) * sy * project.BasicCalculations.D1y*0.01;
        //            mRdY = Math.Round((Double)mRdY, 2);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdY"));

        //            if (mRdY < 0)
        //            {
        //                mRdY = 0;
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdY"));
        //            }
        //        }
        //    }




        //    // KIERUNEK Z

        //    if (NEdz < project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni + alfa2z)
        //    {
        //        // przypadek ct
        //        if ((project.Column.Concrete.Fck <= 50.0) && (project.Column.Steel.Fyk == 500.0))
        //        {
        //            cParameterCapacityZ = 1.61;
        //        }
        //        else
        //        {
        //            cParameterCapacityZ = 1000 * project.Column.Steel.Es * project.Column.Concrete.EpsilonCu2 / project.BasicCalculations.Fyd;
        //        }
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CParameterCapacityZ"));

        //        ksiZ = (nEdy - alfa2z + alfa1z) / (project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni);
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KsiZ"));

        //        if ((cParameterCapacityZ * (1 - ksiZ) / ksiZ >= 1) && (cParameterCapacityZ * (ksiZ - Delta2z) / ksiZ) >= 1) // warunek I
        //        {
        //            k2Z = Math.Min((cParameterCapacityZ * (ksiZ - Delta2z) / ksiZ), 1);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2Z"));

        //            mRd1Z = project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * ksiZ * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda * ksiZ) +
        //                +k2Z * alfa2z * (1 - delta2z);
        //            mRd1Z = Math.Round((Double)mRd1Z, 4);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Z"));

        //            mRdZ = (mRd1Z - 0.5 * nEdz * (1 - delta1z)) * sz * project.BasicCalculations.D1z * 0.01;
        //            mRdZ = Math.Round((Double)mRdZ, 2);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdZ"));
        //        }

        //        else
        //        {
        //            bNZ = alfa2z + cParameterCapacityZ * alfa1z - nEdz;
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BNZ"));

        //            ksiZ = (Math.Sqrt(bNZ * bNZ + 4 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * cParameterCapacityZ * alfa1z) - bNZ) / (2 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KsiZ"));

        //            if ((cParameterCapacityZ * (1 - ksiZ) / ksiZ < 1) && (cParameterCapacityZ * (ksiZ - Delta2z) / ksiZ) >= 1) // warunek II
        //            {
        //                k2Z = Math.Min((cParameterCapacityZ * (ksiZ - Delta2z) / ksiZ), 1);
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2Z"));

        //                mRd1Z = project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * ksiZ * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda * ksiZ) +
        //                    +k2Z * alfa2z * (1 - delta2z);
        //                mRd1Z = Math.Round((Double)mRd1Z, 4);
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Z"));

        //                mRdZ = (mRd1Z - 0.5 * nEdz * (1 - delta1z)) * sz * project.BasicCalculations.D1z * 0.01;
        //                mRdZ = Math.Round((Double)mRdZ, 2);
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdZ"));
        //            }

        //            else
        //            {
        //                bNZ = cParameterCapacityZ * alfa2z - alfa1z - nEdz;
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BNZ"));

        //                ksiZ = (Math.Sqrt(bNZ * bNZ + 4 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * cParameterCapacityZ * alfa2z * delta2z) - bNZ) / (2 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni);
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KsiZ"));

        //                if ((cParameterCapacityZ * (1 - ksiZ) / ksiZ >= 1) && (cParameterCapacityZ * (ksiZ - Delta2z) / ksiZ) < 1) //warunek III
        //                {
        //                    k2Z = Math.Min((cParameterCapacityZ * (ksiZ - Delta2z) / ksiZ), 1);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("K2Z"));

        //                    mRd1Z = project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * ksiZ * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda * ksiZ) +
        //                        +k2Z * alfa2z * (1 - delta2z);
        //                    mRd1Z = Math.Round((Double)mRd1Z, 4);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Z"));

        //                    mRdZ = (mRd1Z - 0.5 * nEdz * (1 - delta1z)) * sz * project.BasicCalculations.D1z * 0.01;
        //                    mRdZ = Math.Round((Double)mRdZ, 2);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdZ"));
        //                }

        //                else
        //                {
        //                    bNZ = cParameterCapacityZ * alfa2z + cParameterCapacityZ * alfa1z - nEdz;
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BNZ"));

        //                    ksiZ = (Math.Sqrt(bNZ * bNZ + 4 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * (cParameterCapacityZ * alfa2z * delta2z + cParameterCapacityZ * alfa1z)) - bNZ) / (2 * project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KsiZ"));

        //                    mRd1Z = project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * ksiZ * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda * ksiZ) +
        //                     +k2Z * alfa2z * (1 - delta2z);
        //                    mRd1Z = Math.Round((Double)mRd1Z, 4);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Z"));

        //                    mRdZ = (mRd1Z - 0.5 * nEdz * (1 - delta1z)) * sz * project.BasicCalculations.D1z * 0.01;
        //                    mRdZ = Math.Round((Double)mRdZ, 2);
        //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdZ"));
        //                }
        //            }
        //        }
        //    }


        //    else
        //    {
        //        //przypadek cc
        //        if ((project.Column.Concrete.Fck <= 50.0) && (project.Column.Steel.Fyk == 500.0))
        //        {
        //            kParameterCapacityZ = 0.805;
        //        }
        //        else
        //        {
        //            kParameterCapacityZ = Math.Min(1000 * project.Column.Steel.Es * project.Column.Concrete.EpsilonC3 / project.BasicCalculations.Fyd, 1);
        //        }
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KParameterCapacityZ"));


        //        if (project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni < nEdz && nEdz < project.Column.LoadCapacityParameters.Ni * (1 + delta1z) + kParameterCapacityZ * (alfa1z + alfa2z))
        //        {
        //            mRd1Z = Math.Min(project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda) + alfa2z * (1 - delta2z),
        //                0.5 * project.Column.LoadCapacityParameters.Ni * (1 - delta1z * delta1z) + kParameterCapacityZ * alfa2z * (1 - delta2z));
        //            mRd1Z = Math.Round((Double)mRd1Z, 4);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Z"));

        //            mRdZ = (mRd1Z - 0.5 * nEdz * (1 - delta1z)) * sz * project.BasicCalculations.D1z * 0.01;
        //            mRdZ = Math.Round((Double)mRdZ, 2);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdZ"));

        //            if (mRdZ < 0)
        //            {
        //                mRdZ = 0;
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdZ"));
        //            }
        //        }

        //        else
        //        {
        //            //niewiem co ???


        //            mRd1Z = Math.Min(project.Column.LoadCapacityParameters.Lambda * project.Column.LoadCapacityParameters.Ni * (1 - 0.5 * project.Column.LoadCapacityParameters.Lambda) + alfa2z * (1 - delta2z),
        //            0.5 * project.Column.LoadCapacityParameters.Ni * (1 - delta1z * delta1z) + kParameterCapacityZ * alfa2z * (1 - delta2z));
        //            mRd1Z = Math.Round((Double)mRd1Z, 4);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRd1Z"));

        //            mRdZ = (mRd1Z - 0.5 * nEdz * (1 - delta1z)) * sz * project.BasicCalculations.D1z * 0.01;
        //            mRdZ = Math.Round((Double)mRdZ, 2);
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdZ"));

        //            if (mRdZ < 0)
        //            {
        //                mRdZ = 0;
        //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MRdZ"));
        //            }
        //        }
        //    }

        //    //SPRAWDZIĆ KIERUNKI
        //    if (project.SecondOrderCalculations.Medz <= mRdY)
        //    {
        //        loadCapacityCheckingCommentY = "SPEŁNIONY";
        //        loadCapacityCheckingWarningY = "Nośność słupa jest wystarczająca.";
        //    }
        //    else
        //    {
        //        loadCapacityCheckingCommentY = "NIESPEŁNIONY";
        //        loadCapacityCheckingWarningY = "Nośność słupa nie jest wystarczająca.";
        //    }
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoadCapacityCheckingCommentY"));
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoadCapacityCheckingWarningY"));

        //    if (project.SecondOrderCalculations.Medy <= mRdZ)
        //    {
        //        loadCapacityCheckingCommentZ = "SPEŁNIONY";
        //        loadCapacityCheckingWarningZ = "Nośność słupa jest wystarczająca.";
        //    }
        //    else
        //    {
        //        loadCapacityCheckingCommentZ = "NIESPEŁNIONY";
        //        loadCapacityCheckingWarningZ = "Nośność słupa nie jest wystarczająca.";
        //    }
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoadCapacityCheckingCommentZ"));
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoadCapacityCheckingWarningZ"));






    }
    //}
}

