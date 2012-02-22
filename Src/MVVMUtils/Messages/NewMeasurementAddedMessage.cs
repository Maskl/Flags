using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clime.Model;

namespace Clime.Messages
{
    class NewMeasurementAddedMessage
    {
        public NewMeasurementAddedMessage(Measurement v)
        {
            MeasurementAdded = v;
        }
        public Measurement MeasurementAdded { get; private set; }
    }
}
