using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public sealed class ReferenceNumberSingletonService
    {
        private static string nextRefNumber = "";
        private static ReferenceNumberSingletonService? instance = null;
        private ReferenceNumberSingletonService()
        {

        }

        private ReferenceNumberSingletonService(int recordCount, CargoReferenceNumberType referenceType)
        {
            var today = DateTime.Now;
            string postfix = "0000" + (recordCount + 1);
            string incementalNumber = postfix.Substring(postfix.Length - 4);
            string month = today.Month > 9 ? today.Month.ToString() : "0" + today.Month;
            string firstPrefix = referenceType == CargoReferenceNumberType.Booking ? "B" : "P";
            nextRefNumber = string.Format("{0}{1}{2}{3}", firstPrefix, today.Year, month, incementalNumber);
        }

        public static ReferenceNumberSingletonService GetInstance(int recourdCount, CargoReferenceNumberType referenceType)
        {
            instance = new ReferenceNumberSingletonService(recourdCount, referenceType);
            return instance;
        }

        public string GetNextRefNumber() => nextRefNumber;
    }
}
