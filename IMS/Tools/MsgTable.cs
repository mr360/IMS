using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public enum EnumMsg
    {
        // Exception message table
        MSG_NULL_EXCEPTION_NOT_ADDON = -2000,
        MSG_NULL_EXCEPTION_NOT_REPORT = -1999,
        MSG_NULL_EXCEPTION_NOT_USER = -1998,
        MSG_NULL_EXCEPTION_NOT_VEHICLE = -1997,
        MSG_NULL_EXCEPTION_NOT_INVOICE = -1996,
        MSG_NULL_EXCEPTION_NOT_BAY = -1995,

        // Managers message table
        MSG_SUCCESS_ADD_REPORT,
        MSG_SUCCESS_ADD_USER,
        MSG_SUCCESS_ADD_VEHICLE,
        MSG_SUCCESS_ADD_INVOICE,
        MSG_SUCCESS_ADD_BAY,
        MSG_SUCCESS_ADD_ADDON,
        MSG_ERROR_DUPLICATE_REPORT = -1000,
        MSG_ERROR_DUPLICATE_USER = -999,
        MSG_ERROR_DUPLICATE_VEHICLE = -998,
        MSG_ERROR_DUPLICATE_INVOICE = -997,
        MSG_ERROR_DUPLICATE_BAY = -996,
        MSG_ERROR_DUPLICATE_ADDON = -995,

        // Payment Processor message table
        MSG_VALID_CARD

        // Instances message table


    };
}

namespace IMS.Tools
{
    public class StringTable
    {
        public static string EnumToString(EnumMsg msg)
        {
            switch(msg)
            {
                default: return "Unknown msg";
            }
        }
    }
}
