using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchosignRESTClient.Models
{
    public class UserWidget
    {
        /// <summary>
        /// The embedded javascript code of the widget
        /// </summary>
        public string javascript { get; set; }

        /// <summary>
        /// The day on which the widget was last modified
        /// </summary>
        public DateTime modifiedDate { get; set; }

        /// <summary>
        /// The name of the widget
        /// </summary>
        public string name { get; set; }

        //TODO: Enumeration
        /// <summary>
        /// ['ENABLED' or 'DISABLED' or 'ABORTED' or 'OTHER']: The widget status (enabled or disabled or aborted or other)
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// The hosted url of the widget
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// The unique identifier of a widget
        /// </summary>
        public string widgetId { get; set; }
    }
}
