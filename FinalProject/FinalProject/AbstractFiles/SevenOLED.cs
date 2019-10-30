using FinalProject.BaseFiles;

namespace FinalProject.AbstractFiles

{
    public class SevenOLED : AbstractReaderBase

    {
        public override decimal Price { get; } = 99.00m;
        public override string EReaderDescript { get; } = "7 inch OLED";


        public SevenOLED(ReaderColor color)

            : base(color, true) { }



        public SevenOLED()

            : this(ReaderColor.Bronze) { }



    } // end class

} // end namespace
