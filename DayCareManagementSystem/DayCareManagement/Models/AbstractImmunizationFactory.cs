using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public abstract class AbstractImmunizationFactory
    {
        public abstract Immunization getObject();

        public abstract Immunization getObject(String csvData);

    }
}
