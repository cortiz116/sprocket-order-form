//Christiana Ortiz
//cortiz116@cnm.edu
//19 November 2023
//OrtizP5

using System;

namespace OrtizP5
{

    public abstract class Sprocket
    {


        //fields
        private int numItems;
        private int numTeeth;

        //fully qualified properties
        public int NumItems
        { 
            get { return numItems; }
            set { numItems = value; }
        }

        public int NumTeeth
        {
            get { return numTeeth; }
            set { numTeeth = value; }
        }

        //read only properties
        public decimal Price { get; protected set; }
        public int ItemId { get; private set; }

        //Constructor (Parameterless)
        protected Sprocket()
        {

        }
        //3-Parameter constructor (itemID, numItems, and numTeeth)
        protected Sprocket(int itemID, int numItems, int numTeeth)
        {
            ItemId = itemID;
            NumTeeth = numTeeth;
            NumItems = numItems;
        }

        //Calculate Method implemented in child classes to calculate price
        protected abstract void Calculate();

        //Base ToString - concatenates itemID, itemNum, teethNum, and total price
        public override string ToString()
        {
            return $"Order Number: {ItemId} Number: {NumItems} Teeth: {NumTeeth} Price: ${Price}";
        }

        //SteelSprocket class inherits from abstract Sprocket class
        public class SteelSprocket : Sprocket
        {
            public SteelSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
            {
                Calculate();
            }
            //Multiplies number of items by number of teeth at 5 cents a tooth
            protected override void Calculate()
            {
                Price = NumTeeth * NumItems * 0.05m;
            }
            //Adds material to base ToString
            public override string ToString()
            {
                return base.ToString() + "Material: steel";
            }
        }

        //AluminumSprocket class inherits from abstract Sprocket class
        public class AluminumSprocket : Sprocket
        {
            public AluminumSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
            {
                Calculate();
            }

            //Multiplies number of items by number of teeth at 4 cents a tooth
            protected override void Calculate()
            {
                Price = NumTeeth * NumItems * 0.04m;
            }

            //Adds material to base ToString
            public override string ToString()
            {
                return base.ToString() + "Material: aluminum";
            }
        }

        //PlasticSprocket class inherits from abstract Sprocket class
        public class PlasticSprocket : Sprocket
        {
            public PlasticSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
            {
                Calculate();
            }

            //Multiplies number of items by number of teeth at 2 cents a tooth
            protected override void Calculate()
            {
                Price = NumTeeth * NumItems * 0.02m;
            }

            //Adds material to base ToString
            public override string ToString()
            {
                return base.ToString() + "Material: plastic";
            }
        }
    }
}
