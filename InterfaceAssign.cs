using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent3aug
{
    interface IVolume
    {
        double Volume { get; }
    }
    interface IArea
    {
        double SurfaceArea();
    }

    interface ISolid : IArea, IVolume
    {

    }
    abstract class Solid : ISolid
    {
        double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        const double pi = 3.142;
        public double Pi
        {
            get { return pi; }

        }
        public Solid()
        {

        }
        public Solid(double _radius, double _pi)

        {
            radius = _radius;

        }
        // double IVolume.Volume => throw new NotImplementedException();
        public abstract double Volume
        {
            get;
        }

        //double IArea.SurfaceArea()
        //{
        //    throw new NotImplementedException();
        //}
        public abstract double SurfaceArea();



    }
    class Cylinder : Solid
    {
        double height;
        public Cylinder()
        {

        }
        public Cylinder(double _height, double _radius, double _pi) : base(_radius, _pi)
        {
            height = _height;
        }

        public override double Volume
        {
            get
            {
                double volume = Pi * Radius * height;
                return volume;
            }

        }
        public override double SurfaceArea()
        {
            double surfaceArea = 2 * Pi * Radius * (Radius + height);
            return surfaceArea;
        }
    }
    class Sphere : Solid
    {
        public Sphere()
        {

        }
        public Sphere(double _radius, double _pi) : base(_radius, _pi)
        {

        }
        public override double SurfaceArea()
        {
            double surfaceArea = 4 / 3 * Pi * Radius * Radius * Radius;
            return surfaceArea;
        }
        public override double Volume
        {
            get
            {
                double volume = 4 * Pi * Radius * Radius;

                return volume;
            }

        }
    }
    class InterfaceAssign
    {
        static void Main()
        {
            //cylinder
            Cylinder cyl = new Cylinder(3,6, 3.14);
            Console.WriteLine("Volume of            Cylinder   :    {0}", cyl.Volume);
            Console.WriteLine("Surface area  of         Cylinder   :    {0}", cyl.SurfaceArea());
            Console.WriteLine("...................................................");
            //sphere
            Sphere Sph = new Sphere(2.77, 3.14);
            Console.WriteLine(" Volume of              Sphere    :   {0}", Sph.Volume);
            Console.WriteLine("Surface area of         Sphere    :   {0}", Sph.SurfaceArea());
            Console.WriteLine("...................................................");


        }
    }
}

