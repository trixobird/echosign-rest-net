using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchosignRESTClient.Models
{
    public class FormFieldCondition
    {
        /// <summary>
        ///  (optional) Value to compare the value of the whenField with, to evaluate the condition
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// (optional) Index of the location of the whenField whose value is the basis of the condition
        /// </summary>
        public int whenFieldLocationIndex { get; set; }

        /// <summary>
        /// (optional) Name of the field whose value is the basis of condition
        /// </summary>
        public string whenFieldName { get; set; }
    }
}
