

using FinalProject.BaseFiles;

namespace FinalProject.AbstractFiles

{

    public  class TwelveOLED : AbstractReaderBase

    {

        public override decimal Price { get; } = 150.00m;
        public override string EReaderDescript { get; } = "12 inch OLED";


        public TwelveOLED(ReaderColor color)

            : base(color, true) { }



        public TwelveOLED()

            : this(ReaderColor.Candy_Apple) { }



    } // end class

} // end namespace
