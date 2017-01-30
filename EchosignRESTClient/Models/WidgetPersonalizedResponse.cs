using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchosignRESTClient.Models
{
    public class WidgetPersonalizedResponse
    {
        /// <summary>
        ///  Javascript snippet suitable for an embedded page taking a user to a URL
        /// </summary>
        public string javascript { get; set; }

        /// <summary>
        /// Standalone URL to direct end users to
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// The unique identifier of widget which can be used to retrieve the data entered by the signers
        /// </summary>
        public string widgetId { get; set; }
    }
}
