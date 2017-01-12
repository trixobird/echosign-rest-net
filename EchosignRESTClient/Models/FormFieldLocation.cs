using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchosignRESTClient.Models
{
    public class FormFieldLocation
    {
        /// <summary>
        /// (required) Height of the form field in pixels
        /// </summary>
        public double height { get; set; }

        /// <summary>
        /// (required) No. of pixels from left of the page for form field placement
        /// </summary>
        public double left { get; set; }

        /// <summary>
        /// (required) Number of the page where form field has to be placed, starting from 1.
        /// </summary>
        public int pageNumber { get; set; }

        /// <summary>
        /// (required) No. of pixels from bottom of the page for form field placement
        /// </summary>
        public double top { get; set; }

        /// <summary>
        /// (required) Width of the form field in pixels
        /// </summary>
        public double width { get; set; }
    }
}
