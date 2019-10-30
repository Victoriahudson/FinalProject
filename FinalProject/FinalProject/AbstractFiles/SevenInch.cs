using FinalProject.BaseFiles;

namespace FinalProject.AbstractFiles

{
    public class SevenInch : AbstractReaderBase
    {

        public override decimal Price { get; } = 85.00m;
        public override string EReaderDescript { get; } = "7 inch EInk";


        public SevenInch(ReaderColor color)
            : base(color, false) { }



        public SevenInch()
            : this(ReaderColor.Black) { }



    } // end class

} // end namespace