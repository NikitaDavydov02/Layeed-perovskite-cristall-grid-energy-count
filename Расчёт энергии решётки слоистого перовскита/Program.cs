using System;
using System.Collections.Generic;

namespace Расчёт_энергии_решётки_слоистого_перовскита
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 3.871 * Math.Pow(10, -10);
            //double b = 3.871 * Math.Pow(10, -10);
            //double c = 29.782 * Math.Pow(10, -10);

            //double a = 3.898 * Math.Pow(10, -10);
            //double b = 3.898 * Math.Pow(10, -10);
            //double c = 30.502 * Math.Pow(10, -10);

            double a = 3.871 * Math.Pow(10, -10);
            double b = 3.871 * Math.Pow(10, -10);
            double c = 30.502 * Math.Pow(10, -10);

            //double a = 5.63874 * Math.Pow(10, -10);
            //double b = 5.63874 * Math.Pow(10, -10);
            //double c = 5.63874 * Math.Pow(10, -10);

            //double a = 1;
            //double b = 1;
            //double c = 1;
            double e = 1.6 * Math.Pow(10, -19);
            //double e = 1;
            double k = 9 * Math.Pow(10, 9);
            double Na = 6.02 * Math.Pow(10, 23);
            int z = 2;

            double U = 0;
            double M = 0;

            Console.WriteLine("Введите диапозон (радиус расчёта в элементарных ячейках)");
            int diapozon = Convert.ToInt32(Console.ReadLine());


            Dictionary<Vector3, double> cellAtoms = new Dictionary<Vector3, double>();


            ////1.Задание координат атомов

            //cellAtoms.Add(new Vector3(a / 2, a / 2, a / 2), e / 8);
            //cellAtoms.Add(new Vector3(a / 2, -a / 2, a / 2), e / 8);
            //cellAtoms.Add(new Vector3(-a / 2, a / 2, a / 2), e / 8);
            //cellAtoms.Add(new Vector3(-a / 2, -a / 2, a / 2), e / 8);

            //cellAtoms.Add(new Vector3(a / 2, a / 2, -a / 2), e / 8);
            //cellAtoms.Add(new Vector3(a / 2, -a / 2, -a / 2), e / 8);
            //cellAtoms.Add(new Vector3(-a / 2, a / 2, -a / 2), e / 8);
            //cellAtoms.Add(new Vector3(-a / 2, -a / 2, -a / 2), e / 8);

            //cellAtoms.Add(new Vector3(0, 0, a / 2), e / 2);
            //cellAtoms.Add(new Vector3(0, 0, -a / 2), e / 2);
            //cellAtoms.Add(new Vector3(0, a / 2, 0), e / 2);
            //cellAtoms.Add(new Vector3(0, -a / 2, 0), e / 2);
            //cellAtoms.Add(new Vector3(a / 2, 0, 0), e / 2);
            //cellAtoms.Add(new Vector3(-a / 2, 0, 0), e / 2);

            //cellAtoms.Add(new Vector3(0, 0, 0), -e);

            //cellAtoms.Add(new Vector3(a / 2, a / 2, 0), -e / 4);
            //cellAtoms.Add(new Vector3(a / 2, -a / 2, 0), -e / 4);
            //cellAtoms.Add(new Vector3(-a / 2, a / 2, 0), -e / 4);
            //cellAtoms.Add(new Vector3(-a / 2, -a / 2, 0), -e / 4);

            //cellAtoms.Add(new Vector3(0, a / 2, a / 2), -e / 4);
            //cellAtoms.Add(new Vector3(0, -a / 2, a / 2), -e / 4);
            //cellAtoms.Add(new Vector3(a / 2, 0, a / 2), -e / 4);
            //cellAtoms.Add(new Vector3(-a / 2, 0, a / 2), -e / 4);

            //cellAtoms.Add(new Vector3(0, a / 2, -a / 2), -e / 4);
            //cellAtoms.Add(new Vector3(0, -a / 2, -a / 2), -e / 4);
            //cellAtoms.Add(new Vector3(a / 2, 0, -a / 2), -e / 4);
            //cellAtoms.Add(new Vector3(-a / 2, 0, -a / 2), -e / 4);

            ////1.1.1 Задание координат атомов калия в ячейке
            cellAtoms.Add(new Vector3(0, 0, (c - 3 * a) / 2), e);
            cellAtoms.Add(new Vector3(0, 0, -(c - 3 * a) / 2), e);

            cellAtoms.Add(new Vector3(a / 2, a / 2, 3 * a / 2), e/4);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, 3 * a / 2), e/4);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, 3 * a / 2), e/4);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, 3 * a / 2), e/4);
            cellAtoms.Add(new Vector3(a / 2, a / 2, -3 * a / 2), e/4);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, -3 * a / 2), e/4);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, -3 * a / 2), e/4);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, -3 * a / 2), e/4);

            ////1.1.2 Задание координат атомов лантана в ячейке
            cellAtoms.Add(new Vector3(0, 0, (c - a) / 2), 3 * e);
            cellAtoms.Add(new Vector3(0, 0, -(c - a) / 2), 3 * e);

            cellAtoms.Add(new Vector3(a / 2, a / 2, a / 2), 3 * e / 4);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, a / 2), 3 * e /4);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, a / 2), 3 * e /4);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, a / 2), 3 * e /4);
            cellAtoms.Add(new Vector3(a / 2, a / 2, -a / 2), 3 * e /4);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, -a / 2), 3 * e /4);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, -a / 2), 3 * e /4);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, -a / 2), 3 * e /4);

            ////1.1.3 Задание координат атомов титана в ячейке
            cellAtoms.Add(new Vector3(0, 0, 0), 4 * e);

            cellAtoms.Add(new Vector3(0, 0, a), 4 * e);
            cellAtoms.Add(new Vector3(0, 0, -a), 4 * e);

            cellAtoms.Add(new Vector3(a / 2, a / 2, (c/2)-a), e);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, (c / 2) - a), e);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, (c / 2) - a), e);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, (c / 2) - a), e);
            cellAtoms.Add(new Vector3(a / 2, a / 2, a-(c/2)), e);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, a - (c / 2)), e);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, a - (c / 2)), e);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, a - (c / 2)), e);

            cellAtoms.Add(new Vector3(a / 2, a / 2, c / 2), e / 2);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, c / 2), e / 2);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, c / 2), e / 2);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, c / 2), e / 2);
            cellAtoms.Add(new Vector3(a / 2, a / 2, -c / 2), e / 2);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, -c / 2), e / 2);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, -c / 2), e / 2);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, -c / 2), e / 2);

            ////1.1.4 Задание координат атомов кислорода в ячейке
            cellAtoms.Add(new Vector3(0, 0, a / 2), -2 * e);
            cellAtoms.Add(new Vector3(0, 0, 3 * a / 2), -2 * e);
            cellAtoms.Add(new Vector3(0, 0, -a / 2), -2 * e);
            cellAtoms.Add(new Vector3(0, 0, -3 * a / 2), -2 * e);

            cellAtoms.Add(new Vector3(a / 2, 0, c / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, 0, c / 2), -e / 2);
            cellAtoms.Add(new Vector3(0, a/2, c / 2), -e / 2);
            cellAtoms.Add(new Vector3(0 , -a/2, c / 2), -e / 2);
            cellAtoms.Add(new Vector3(a / 2, 0, -c / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, 0, -c / 2), -e / 2);
            cellAtoms.Add(new Vector3(0, a / 2, -c / 2), -e / 2);
            cellAtoms.Add(new Vector3(0, -a / 2, -c / 2), -e / 2);

            cellAtoms.Add(new Vector3(a / 2, a / 2, (c-a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, (c - a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, (c - a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, (c - a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(a / 2, a / 2, -(c - a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, -(c - a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, -(c - a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, -(c - a) / 2), -e / 2);

            cellAtoms.Add(new Vector3(a / 2, 0, (c / 2)-a), -e);
            cellAtoms.Add(new Vector3(-a / 2, 0, (c / 2) - a), -e);
            cellAtoms.Add(new Vector3(0, a / 2, (c / 2) - a), -e);
            cellAtoms.Add(new Vector3(0, -a / 2, (c / 2) - a), -e);
            cellAtoms.Add(new Vector3(a / 2, 0, a-(c/2)), -e);
            cellAtoms.Add(new Vector3(-a / 2, 0, a - (c / 2)), -e);
            cellAtoms.Add(new Vector3(0, a / 2, a - (c / 2)), -e);
            cellAtoms.Add(new Vector3(0, -a / 2, a - (c / 2)), -e);

            cellAtoms.Add(new Vector3(a / 2, a / 2, (c - 3 * a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, (c - 3 * a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, (c - 3 * a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, (c - 3 * a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(a / 2, a / 2, -(c - 3 * a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(a / 2, -a / 2, -(c - 3 * a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, a / 2, -(c - 3 * a) / 2), -e / 2);
            cellAtoms.Add(new Vector3(-a / 2, -a / 2, -(c - 3 * a) / 2), -e / 2);

            cellAtoms.Add(new Vector3(a / 2, 0, a), -e);
            cellAtoms.Add(new Vector3(-a / 2, 0, a), -e);
            cellAtoms.Add(new Vector3(0, a / 2, a), -e);
            cellAtoms.Add(new Vector3(0, -a / 2, a), -e);
            cellAtoms.Add(new Vector3(a / 2, 0, -a), -e);
            cellAtoms.Add(new Vector3(-a / 2, 0, -a), -e);
            cellAtoms.Add(new Vector3(0, a / 2, -a), -e);
            cellAtoms.Add(new Vector3(0, -a / 2, -a), -e);

            cellAtoms.Add(new Vector3(a / 2, 0, 0), -e);
            cellAtoms.Add(new Vector3(-a / 2, 0, 0), -e);
            cellAtoms.Add(new Vector3(0, a / 2, 0), -e);
            cellAtoms.Add(new Vector3(0, -a / 2, 0), -e);

            //2. Энергия решётки
            Vector3 center = new Vector3(a/2, 0, 0);

            foreach (Vector3 cellAtom in cellAtoms.Keys)
            {
                if(cellAtom.x==0 && cellAtom.y == 0 && cellAtom.z == 0)
                {

                }
                M = 0;
                double DU = 0;
                for (int i = -diapozon; i <= diapozon; i++)
                {
                    for (int j = -diapozon; j <= diapozon; j++)
                    {
                        for (int ko = -diapozon; ko <= diapozon; ko++)
                        {
                            double deltaX = i * a;
                            double deltaY = j * b;
                            double deltaZ = ko * c;
                            Vector3 deltaPosition = new Vector3(deltaX, deltaY, deltaZ);
                            foreach (Vector3 anotherAtom in cellAtoms.Keys)
                            {
                                Vector3 anotherAtomPosition = VectorMath.Sum(anotherAtom, deltaPosition);
                                double distance = VectorMath.Magnitude(VectorMath.Difference(anotherAtomPosition, cellAtom));
                                if (distance != 0)
                                {
                                    double dU = cellAtoms[cellAtom] * cellAtoms[anotherAtom] / distance;
                                    //Console.WriteLine(distance/a);
                                    double dM = (a * cellAtoms[anotherAtom]) / (2 * distance * e);
                                    M += dM;
                                    if (Math.Abs(dM) > 1)
                                    {
                                        //Console.WriteLine("Help!" + dM);
                                    }
                                    U += dU/2;
                                    DU += dU/2;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(cellAtom.x/a + " " + cellAtom.y / a + " " + cellAtom.z / a);
                Console.WriteLine(Na * k * DU);
                Console.WriteLine(Na * k * U);
                //Console.WriteLine("M = " + M);
            }

            //for (int i = -diapozon; i<= diapozon; i ++)
            //{
            //    for (int j = -diapozon; j <= diapozon; j++)
            //    {
            //        for (int ko = -diapozon; ko <= diapozon; ko++)
            //        {
            //            //Сдвиг
            //            double deltaX = i * a;
            //            double deltaY = j * b;
            //            double deltaZ = ko * c;
            //            Vector3 deltaPosition = new Vector3(deltaX, deltaY, deltaZ);
            //            //foreach(Vector3 cellAtom in cellAtoms.Keys)
            //            //{
            //            //    foreach(Vector3 anotherAtom in cellAtoms.Keys)
            //            //    {
            //            //        Vector3 anotherAtomPosition = VectorMath.Sum(anotherAtom, deltaPosition);
            //            //        double distance = VectorMath.Magnitude(VectorMath.Difference(anotherAtomPosition, cellAtom));
            //            //        if (distance != 0)
            //            //        {
            //            //            double dU = (k * cellAtoms[cellAtom] * cellAtoms[anotherAtom]) / distance;
            //            //            U += dU / 2;
            //            //        }
            //            //    }
            //            //}




            //            //foreach (Vector3 anotherAtom in cellAtoms.Keys)
            //            //{
            //            //Vector3 anotherAtomPosition = VectorMath.Sum(anotherAtom, deltaPosition);
            //            //double distance = VectorMath.Magnitude(VectorMath.Difference(anotherAtomPosition, center));
            //            //    if (distance != 0)
            //            //    {
            //            //        double dU = cellAtoms[anotherAtom] / distance;
            //            //        double dM = (a * cellAtoms[anotherAtom]) / (2 * distance * e);
            //            //        M += dM;
            //            //        if (Math.Abs(dM) > 1)
            //            //        {
            //            //            Console.WriteLine("Help!");
            //            //        }
            //            //        U += dU;
            //            //    }
            //            //}
            //        }
            //    }
            //}
            double Um = Na * k * U;
            Console.WriteLine("U = " + (Um / 1000) + " кДж/моль");
            Console.WriteLine("M = " + M);
        }
    }
}
