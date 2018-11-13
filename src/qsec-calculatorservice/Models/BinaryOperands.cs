using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace qsec_calculatorservice.Models {
    public class BinaryOperands
    {
        [BindRequired]
        public decimal A { get; set; }
        // [BindRequired]
        public decimal B { get; set; }

        public BinaryOperands(decimal a, decimal b) {
            this.A = a;
            this.B = b;
        }

        public decimal Add() {
            return A+B;
        }
    }
}