using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");
            IPipe nulo = new PipeNull();
            IFilter negativo = new FilterNegative();
            IPipe serial1 = new PipeSerial(negativo,nulo);
            IFilter gris = new FilterGreyscale();
            IPipe serial2 = new PipeSerial(gris, serial1);
            IPicture final = serial2.Send(picture);
            provider.SavePicture(final, @"save.jpg");
        }
    }
}
