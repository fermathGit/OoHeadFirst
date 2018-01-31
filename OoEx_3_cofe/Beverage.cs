using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_3_cofe {
    public abstract class Beverage {
        public enum BeverageSize {
            Big = 1,
            Mid = 2,
            Small = 3
        }
        public string m_description = "Unknown Beverage";

        BeverageSize m_beverageSize;

        public abstract string GetDescription();

        public abstract double Cost();

        public virtual BeverageSize GetSize() { return m_beverageSize; }

        public virtual void SetSize( BeverageSize beverageSize ) { m_beverageSize = beverageSize; }
    }
}
