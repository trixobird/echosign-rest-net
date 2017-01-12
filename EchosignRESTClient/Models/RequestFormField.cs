using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchosignRESTClient.Models
{
    public class RequestFormField
    {
        /// <summary>
        /// (required) All locations in a document where the form field is placed
        /// </summary>
        public List<FormFieldLocation> locations { get; set; }

        /// <summary>
        /// (required) The name of the form field
        /// </summary>
        public string name { get; set; }

        //TODO: enum
        /// <summary>
        /// (optional) ['LEFT' or 'RIGHT' or 'CENTER']: Alignment of the text.
        /// </summary>
        public string alignment { get; set; }

        //TODO: enum
        /// <summary>
        /// (optional) ['ALL' or 'ANY']: It indicates if any one of the conditions or all of them have to be true.
        /// </summary>
        public string anyOrAll { get; set; }

        /// <summary>
        /// (optional) Background color of the form field in RGB or HEX forma
        /// </summary>
        public string backgroundColor { get; set; }

        /// <summary>
        /// (optional) Color of the border of the field in RGB or HEX format
        /// </summary>
        public string borderColor { get; set; }

        //TODO: enum
        /// <summary>
        /// (optional) ['SOLID' or 'DASHED' or 'BEVELED' or 'INSET' or 'UNDERLINE']: Style of the border of the field.
        /// </summary>
        public string borderStyle { get; set; }

        /// <summary>
        /// (optional) Width of the border of the field in pixels
        /// </summary>
        public string borderWidth { get; set; }

        /// <summary>
        /// (optional) Expression to calculate value of the form field
        /// </summary>
        public string calculatedExpression { get; set; }

        /// <summary>
        /// (optional) Conditions to be evaluated which decides the visibility of the form field in association with showOrHide property
        /// </summary>
        public List<FormFieldCondition> conditions { get; set; }

        //TODO: enum
        /// <summary>
        /// (optional)  ['DATA' or 'SIGNATURE_BLOCK' or 'SIGNATURE' or 'SIGNER_NAME' or 'SIGNER_FIRST_NAME' 
        /// or 'SIGNER_LAST_NAME' or 'SIGNER_INITIALS' or 'SIGNER_EMAIL' or 'SIGNER_TITLE' or 'SIGNER_COMPANY' 
        /// or 'SIGNATURE_DATE' or 'AGREEMENT_NAME' or 'AGREEMENT_MESSAGE' or 'TRANSACTION_ID' 
        /// or 'SIGNATURE_STAMP' or 'CALC']: Content Type of the form field.
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        /// (optional) Default value of the form field
        /// </summary>
        public string defaultValue { get; set; }

        /// <summary>
        /// (optional) Format of the value of the field to be displayed based on the displayFormatType property.
        /// </summary>
        public string displayFormat { get; set; }

        //TODO: enum
        /// <summary>
        /// (optional) ['DEFAULT' or 'DATE' or 'NUMBER']: Format type of the text field.
        /// </summary>
        public string displayFormatType { get; set; }

        /// <summary>
        /// (optional) Display label attached to the field
        /// </summary>
        public string displayLabel { get; set; }

        /// <summary>
        /// (optional) Font color of the form field in RGB or HEX format
        /// </summary>
        public string fontColor { get; set; }

        /// <summary>
        /// (optional) Font name of the form field
        /// </summary>
        public string fontName { get; set; }

        /// <summary>
        /// (optional) Font size of the form field in points
        /// </summary>
        public string fontSize { get; set; }

        //TODO: enum
        /// <summary>
        /// (optional) ['CUSTOM' or 'DATE' or 'DATE_CUSTOM' or 'DATE_DD_MM_YY' or 'DATE_DD_MM_YYYY' 
        /// or 'DATE_MM_DD_YY' or 'DATE_MM_DD_YYYY' or 'DATE_MM_YY' or 'EMAIL' or 'FORMULA' or 'MONEY' 
        /// or 'MONEY_UK' or 'NONE' or 'NUMBER' or 'PERCENT' or 'PHONE' or 'PHONE_UK' or 'SOCIAL_SEC' 
        /// or 'SPECIAL' or 'STRING' or 'STRING_ALPHA' or 'STRING_ALPHANUM' or 'STRING_NUM' or 'TIME' 
        /// or 'XFA_PICTURE' or 'ZIP' or 'ZIP4' or 'ZIP_UK']: Format of the form field
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// (optional) The format of data in text field
        /// </summary>
        public string formatData { get; set; }

        /// <summary>
        /// (optional) true if the field is hidden, else false
        /// </summary>
        public string hidden { get; set; }

        /// <summary>
        /// (optional) Text values which are hidden in a drop down form field
        /// </summary>
        public List<string> hiddenOptions { get; set; }

        //TODO: enum
        /// <summary>
        /// (optional) ['TEXT_FIELD' or 'MULTILINE' or 'PASSWORD' or 'RADIO' or 'CHECKBOX' or 'DROP_DOWN' or 
        /// 'LISTBOX' or 'SIGNATURE' or 'PDF_SIGNATURE' or 'BUTTON' or 'BLOCK' or 'FILE_CHOOSER' or 'COMB' or 
        /// 'UNSUPPORTED']: Input type of the form field
        /// </summary>
        public string inputType { get; set; }

        /// <summary>
        /// (optional) true if the input entered by the signer has to be masked (like password), else false
        /// </summary>
        public bool masked { get; set; }

        /// <summary>
        /// (optional) Text to mask the masked form field
        /// </summary>
        public string maskingText { get; set; }

        /// <summary>
        /// (optional) Maximum length of the input text field in terms of no. of characters
        /// </summary>
        public int maxLength { get; set; } = 50;

        /// <summary>
        /// (optional) Upper bound of the number that can be entered by the signer
        /// </summary>
        public double maxNumberValue { get; set; } = 9999999999;

        /// <summary>
        /// (optional) Minimum length of the input text field in terms of no. of characters
        /// </summary>
        public int minLength { get; set; }

        /// <summary>
        /// (optional) Lower bound of the number that can be entered by the signer
        /// </summary>
        public double minNumberValue { get; set; }

        //TODO: enum
        /// <summary>
        /// (optional) ['CIRCLE' or 'CHECK' or 'CROSS' or 'DIAMOND' or 'SQUARE' or 'STAR']: 
        /// The type of radio button (if field is radio button, identified by inputType).
        /// </summary>
        public string radioCheckType { get; set; }

        /// <summary>
        /// (optional) true if it is a read-only field, else false
        /// </summary>
        public bool readOnly { get; set; }

        /// <summary>
        /// (optional) Index of recipient, starting from 1, in recipients list passed in the request
        /// </summary>
        public int recipientIndex { get; set; } = 1;
        
        /// <summary>
        /// (optional) Regular expression validation of the form field
        /// </summary>
        public string regularExpression { get; set; }

        /// <summary>
        /// (optional)  true if it is a mandatory field to be filled by the signer, else false
        /// </summary>
        public bool required { get; set; }

        //TODO: enum
        /// <summary>
        /// (optional) ['SHOW' or 'HIDE' or 'DISABLE' or 'ENABLE']: Action to show/hide the form field is to be taken on the basis of evaluation of conditions.
        /// </summary>
        public string showOrHide { get; set; }

        /// <summary>
        /// (optional) Error message to be shown to the signer if filled value doesn't match the validations of the form field
        /// </summary>
        public string specialErrMsg { get; set; }

        /// <summary>
        /// (optional) Formula used to calculate the value of the form field
        /// </summary>
        public string specialFormula { get; set; }

        /// <summary>
        /// (optional) ext that appears while hovering over the field
        /// </summary>
        public string tooltip { get; set; }

        /// <summary>
        /// (optional) Text values which are visible in a drop down form field
        /// </summary>
        public List<string> visibleOptions { get; set; }

    }
}
