﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_3_cofe {
    class HouseBlend : Beverage {
        public HouseBlend() {
            m_description = "House Blend";
        }

        public override double Cost() {
            var size = GetSize();
            if ( size == BeverageSize.Big )
                return 2.89;
            else if ( size == BeverageSize.Mid )
                return 1.89;
            else
                return .89;
        }

        public override string GetDescription() {
            return m_description;
        }
    }
}
