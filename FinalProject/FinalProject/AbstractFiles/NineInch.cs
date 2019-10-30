using FinalProject.BaseFiles;





namespace FinalProject.AbstractFiles

{

    public class NineInch : AbstractReaderBase

    {

        public override decimal Price { get; } = 85.00m;
        public override string EReaderDescript { get; } = "9 inch EInk";


        public NineInch(ReaderColor color)

            : base(color, false) { }



        public NineInch()

            : this(ReaderColor.Black) { }



    } // end class

} // end namespace