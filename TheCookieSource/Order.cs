using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TheCookieSource
{
    /// <summary>
    /// Created 10/12/2020 by Lucas Chapman.
    /// This class is created to create and seralize/deseralize Order objects using a custom exception class and the 
    /// CompareTo() method.
    /// </summary>
    [Serializable]
    public class Order : QuantityIsTooLowException, IComparable, ISerializable
    {
        public static int curOrdnum; // static variable for identifying the current order number
        public int ordnum;  // instance variable for order number
        public DateTime orddate;    // set to the current date
        string custname;
        char ctype;
        string pnum;
        int qty;
        DateTime delivdate;

        /// <summary>
        /// Property for "custname"
        /// </summary>
        public string Custname
        {
            get
            {
                return custname;
            }

            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    custname = value.Trim();
                }
            }
        }


        /// <summary>
        /// Property for "pnum"
        /// </summary>
        public string Pnum
        {
            get
            {
                return pnum;
            }

            set
            {
                // Regex Pattern for validating phone numbers
                string pnumFormat = "^([(][\\d]{3}[)][\\s][\\d]{3}[-][\\d]{4})$";

                if (!string.IsNullOrEmpty(value.Trim()) && Regex.IsMatch(value, pnumFormat))
                {
                    pnum = value.Trim();
                }
            }
        }

        /// <summary>
        /// Property for "ctype"
        /// </summary>
        public char Ctype
        {
            get
            {
                return ctype;
            }

            set
            {
                if (char.ToUpper(value) == 'C' || char.ToUpper(value) == 'O' || char.ToUpper(value) == 'S')
                {
                    ctype = char.ToUpper(value);
                }
            }
        }

        /// <summary>
        /// Property for "qty"
        /// </summary>
        public int Qty
        {
            get
            {
                return qty;
            }

            set
            {
                if (value > 0)
                {
                    qty = value;
                }
                else
                {
                    throw new QuantityIsTooLowException();
                }
            }
        }


        /// <summary>
        /// Property for "delivdate"
        /// </summary>
        public DateTime Delivdate
        {
            get
            {
                return delivdate;
            }

            set
            {
                if (value >= orddate)
                {
                    delivdate = value;
                }
            }
        }

        /// <summary>
        /// Default constructor for the Order class
        /// </summary>
        public Order()
        {
            // Increments curOrdnum by 1 and sets the result to ordnum
            ordnum = Interlocked.Increment(ref curOrdnum);
            Custname = "Lucas Chapman";
            Pnum = "(123) 123-1234";
            Ctype = 'C';
            Qty = 1;    // in dozens
            orddate = DateTime.Now.Date;
            Delivdate = DateTime.Now.AddDays(1).Date;
        }

        /// <summary>
        /// Overloaded constructor for the Order class
        /// </summary>
        /// <param name="cn">Represents the name of the customer</param>
        /// <param name="ct">Represents the cookie type</param>
        /// <param name="pn">Represents the customer's phone number</param>
        /// <param name="q">Represents the quantity of cookies purchased</param>
        /// <param name="dd">Represents the delivery date for the cookies that were purchased</param>
        public Order(string cn, string pn, char ct, int q, DateTime dd)
        {
            // Increments curOrdnum by 1 and sets the result to ordnum
            ordnum = Interlocked.Increment(ref curOrdnum);
            Custname = cn;
            Pnum = pn;
            Ctype = ct;
            Qty = q;
            orddate = DateTime.Now.Date;
            Delivdate = dd.Date;
        }

        /// <summary>
        /// Overrides the GetObjectData() method of the ISerializable interface to serialize objects
        /// </summary>
        /// <param name="info">Stores data for serialization and deserialization</param>
        /// <param name="context">The source/destination of the file stream</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Specifies serialized values
            info.AddValue("ordnum", ordnum);
            info.AddValue("custname", Custname);
            info.AddValue("pnum", Pnum);
            info.AddValue("ctype", Ctype);
            info.AddValue("qty", Qty);
            info.AddValue("orddate", orddate);
            info.AddValue("delivdate", Delivdate);
        }

        /// <summary>
        /// Constructor for deserializing objects
        /// </summary>
        /// <param name="info">Stores data for serialization and deserialization</param>
        /// <param name="context">The source/destination of the file stream</param>
        public Order(SerializationInfo info, StreamingContext context)
        {
            // Retrieves serialized values
            ordnum = info.GetInt32("ordnum");   // Int32 would be considered an "int" datatype
            Custname = info.GetString("custname");
            Pnum = info.GetString("pnum");
            Ctype = info.GetChar("ctype");
            Qty = info.GetInt32("qty");
            orddate = info.GetDateTime("orddate").Date;
            Delivdate = info.GetDateTime("delivdate").Date;
        }

        /// <summary>
        /// Overloaded CompareTo() for sorting delivery dates
        /// </summary>
        /// <param name="obj">Represents the second DateTime object that is being compared</param>
        /// <returns>Returns either a "0" for when the two objects are equal, a "-1" for when the first object is less than the second one, and "1" for when the first object is greater than the second one</returns>
        public int CompareTo(object obj)
        {
            int i = 0;
            Order prev = (Order)obj;

            if (Delivdate < prev.Delivdate)
            {
                i = -1;
            }
            else if (Delivdate > prev.Delivdate)
            {
                i = 1;
            }

            return i;
        }

        /// <summary>
        /// Overrides the ToString() in order to display messages
        /// </summary>
        /// <returns>Returns a formatted message</returns>
        public override string ToString()
        {
            string ctype;

            // Uses the value of Ctype to determine what the full name of the cookie type is
            if (Ctype == 'C')
            {
                ctype = "Cookie";
            }
            else if (Ctype == 'O')
            {
                ctype = "Oatmeal";
            }
            else
            {
                ctype = "Sugar";
            }

            return "Order Number: " + ordnum.ToString("###,##0") + "\n"
                + "Customer Name: " + Custname + "\n"
                + "Phone Number: " + Pnum + "\n"
                + "Cookie Type: " + ctype + "\n"
                + "Quantity: " + Qty.ToString("###,##0") + "\n"
                + "Order Date: " + orddate.ToShortDateString() + "\n"
                + "Delivery Date: " + Delivdate.ToShortDateString();
        }
    }
}